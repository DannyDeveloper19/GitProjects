<?php
class Account extends Controller{

    public function __construct()
    {
        parent::__construct();
    }

    private function createSession($user){
        Session::setSession('User',$user);
    }

    public function destroySession(){
        Session::__destroy();
        echo url_Base();
    }

    public function resetPassword(){
       if (!$_POST) {
            if (isset($_GET['data']) && $_GET['data'] == 1){
                $view = new View('Account/resetPassword.php',1);
            }
        } elseif (isset($_POST['_token']) && NoCSRF::check('_token',$_POST,false,60*3,true)) {
            if(isset($_POST['txt_reset'])){
                $load = new LoadModel('AccountModel');
                $account = new AccountModel();
                $user = $account->resePassword($_POST['txt_reset']);
                if ($user == 0) {
                    echo 'We cannot find any user with the information entered.';
                }elseif (preg_match('/^\([0-9]{3}\)[0-9]{3}[-][0-9]{4}$/',$_POST['txt_reset']) == 1) {
                    $phone =$_POST['txt_reset'];
                    $confirm = eMail::sendText($phone,"Confirmation code","Your activation code is: ".$user[1]);
                    if($confirm){
                        Session::setSession("Code",$user[1]);
                        Session::setSession("ID",$user[0]);
                    }
                    echo ($confirm)? $confirm : 'There was an error sending the message.';
                }else {
                   $confirm = eMail::sendMail($_POST['txt_reset'],$user[2]." ".$user[3],"Confirmation code!!",
                        "Hello ".$user[2]." ".$user[3].":<br/><h3>Insert the code to follow the process:<br/><h3><h2>Code:  ".$user[1]."</h2>");   
                    if($confirm){
                        Session::setSession("Code",$user[1]);
                        Session::setSession("ID",$user[0]);
                    }
                        echo ($confirm)? $confirm : "There was an error in the shipping.";
                }              
                
            }
        }elseif (isset($_POST['txt_code'])) {
            $load = new LoadModel('AccountModel');
            $account = new AccountModel();
            if($_POST['txt_code'] === Session::getSession("Code")){
                $newCode = strval(random_int(10000,99999));
                $user = $account->updateCode($newCode,Session::getSession("ID"));
                Session::setSession("Verified",true);
                Session::setSession("Code","");
                echo url_Base().'/Account/changePassword/1';
            }else{
                Session::setSession("Code","");
                $newCode = strval(random_int(10000,99999));
                $user = $account->updateCode($newCode,Session::getSession("ID"));
                echo 0;
            }
        }
        
    }
    
    public function changePassword(){
        if(Session::getSession("Verified")){
            Session::setSession("Verified","");
            $view = new View('Account/changePassword.php',1);
        }elseif (isset($_POST['_token']) && NoCSRF::check('_token',$_POST,false,60*3,true)) {
             if(isset($_POST['pss_newPassword'])){
                $load = new LoadModel('AccountModel');
                $account = new AccountModel();
                $changed = $account->changePassword($_POST['pss_newPassword'],Session::getSession("ID"));
                if ($changed) {
                    Session::setSession("ID","");
                    echo url_Base()."/Account/login/1";
                }else
                    echo 0;
             }
        }
        else
            $view = new View('Account/resetPassword.php',1);
    }

    public function capture(){
        if(!$_POST)
            $view = new View('Account/camera.php',1);
        else {
            if ($_POST && isset($_POST['image'])) {
                $image = base64_decode($_POST['image']);
                $image = imagecreatefromstring($image);

                $dir = './Content/tmp/';
                if (is_dir($dir)) {
                    //chmod($dir,0777);
                    imagejpeg($image,$dir.'user_photo.jpg',100);
                    //chmod($dir,0600);
                    echo '/Content/tmp/user_photo.jpg';                       
                } else {
                    echo false;
                }
                           
            }
        }
    }

    public function login(){
        $session = Session::getSession('User');
        if ($session != '') {
            header("Location: ".url_Base()."/Guess/index/".$session);
        }else{
            if(!$_POST){
                if (isset($_GET['data']) && $_GET['data'] == 1) {
                $view = new View("Account/login.php",1);
                }
            }elseif (isset($_POST['_token']) && NoCSRF::check('_token',$_POST,false,60*3,true)){
                if (isset($_POST['username']) && isset($_POST['password'])) {
                    $load = new LoadModel('AccountModel');
                    $account = new AccountModel();
                    $user =  strtolower($_POST['username']);
                    $pass = $_POST['password'];
                    $login = $account->login($user);
                    if ($login == null) {
                        echo 1;
                    }else {
                        $pass_hash = $login[1];
                        if (password_verify($pass,$pass_hash)){
                            $id = $login[0];
                            $image = $account->get_User_Image($id);
                            $role = $account->__getRoleById($id);
                            $this->createSession(base64_encode($login[0]));
                            Session::setSession('Name',base64_encode($login[2]." ".$login[3]));
                            Session::setSession('Role',base64_encode($role));
                            Session::setSession('Picture',$image);  
                            
                            echo url_Base()."/Guess/index/".Session::getSession('User');
                        }
                        else{
                            echo 0;
                        }
                    }
                }
            }else{
              echo 2;
            }
        }
        
    }   

    
   public function register($user)
    {
        if (!$_POST) {
            if (isset($_GET['data']) && $_GET['data'] == 1) {
                $view = new View("Account/register.php",1);
            }
        }elseif (isset($_POST['_token']) && NoCSRF::check('_token',$_POST,false,60*3,true)) {
           $load = new LoadModel('Entities/User');
           /*require_once('./Resources/InputFilter.php');
           $filter = new InputFilter();
           $_POST = $filter->process($_POST);*/
           $id = "U".random_int(100000,999999);
           #Preventing XSS attack
           $name = strip_tags(htmlentities($_POST['name']));
           $lastname = strip_tags(htmlentities($_POST['lastname']));
           $address = strip_tags(htmlentities($_POST['street'].", ".$_POST['county'].", ".$_POST['state'].", ".$_POST['zipcode']));
           #Validate if the email already exists
           $email = strtolower(strip_tags(htmlentities($_POST['email'])));
           $phone = strip_tags(htmlentities($_POST['phone']));
           #end block
           $new_user = new Users($id,$name,$lastname,$address,$email,$phone);

           $load = new LoadModel('Entities/Login');
           $nickname =  strtolower(strip_tags(htmlentities($_POST['username'])));
           $password = password_hash(htmlspecialchars($_POST['password']),PASSWORD_BCRYPT);
           $security_code = strval(random_int(10000,99999));
           $is_login = 0;
           $new_login = new Login($id,$nickname,$password,$security_code,$is_login);


           if ($_FILES && $_FILES['picture']['name'] != "") {
               # In case the picture was uploaded
                #Security for uploaded files
                if ((($_FILES["picture"]["type"] == "image/gif")
                    || ($_FILES["picture"]["type"] == "image/jpeg")
                    || ($_FILES["picture"]["type"] == "image/png")
                    || ($_FILES["picture"]["type"] == "image/pjpeg"))
                    )
                {
                  
                   $tmpName = $_FILES['picture']['tmp_name']; 
                   $base64 = fopen($tmpName,'r');
                   $new_user->setPicture($base64);
                    
                }              
           }elseif ($_POST['livepicture']) {
               # in case of the picture was capture
               
               $base64 = fopen($_POST['livepicture'],'r+');
                $new_user->setPicture($base64);
                
                //unlink($_POST['livepicture']);
           }
           
           $load = new LoadModel('Entities/User_Role');
           $role_user = new User_Role($id,2);
           $load = new LoadModel('AccountModel');
           $account = new AccountModel();
           $result = $account->Register($new_user,$new_login,$role_user);
           if($result == 1){
               echo $result;
                          
           }
           elseif($result == 0){  
               fclose($base64);
               unlink($_POST['livepicture']);            
               eMail::SendMail($email,$name." ".$lastname,"New Account!","Welcome ".$name." ".$lastname);
               echo url_Base()."/Account/login/1";
            }elseif ($result != 1 && $result != 0) {
               echo 2; 
           }
           
        }else{
          echo 2;
        }
    }


}
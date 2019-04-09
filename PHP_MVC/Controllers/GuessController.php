<?php
class Guess extends Controller
{
    public function __construct()
    {
        if(isInRole(['admin','guess']))   
            parent::__construct();
        else 
            header("Location: ".url_Base());     
    }
    
    public function index()
    {
        $session = Session::getSession('User');
        if ($session != '') {
            $load = new LoadModel("UserModel");
            $userModel = new UserModel();
            $users = $userModel->select_Users();
            $view = new View("Guess/index.php",compact("users"));
        } else {
            
        }   
    }

    public function remove($id){
        $session = Session::getSession('User');
        if (base64_decode($session) != $id) {
            $load = new LoadModel("UserModel");
            $userModel = new UserModel();
            $user_removed = $userModel->delete_User($id);
            if($user_removed){
                echo url_Base()."/Guess/index/".Session::getSession('User');
            }
            else{
                echo 2;
            }
        }else{
            echo 2;
        }
    }

    public function sendEmail($email){
        //require_once("./Resources/Mail.php");
        if(eMail::SendMail($email," ","New Account!","Welcome again!")){
            echo "<script type='javascript/text'>alert('Done!')</script>";
        }else{
             echo "<script type='javascript/text'>alert('We're presenting problems!)</script>";
        }
    }
}


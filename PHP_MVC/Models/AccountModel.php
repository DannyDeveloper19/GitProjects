<?php
class AccountModel extends Model{
    public function __construct()
    {
        parent::__construct();
    }

    public function resePassword($param){
        $query = (preg_match('/^\([0-9]{3}\)[0-9]{3}[-][0-9]{4}$/',$param) == 1)?
            $this->Select('SELECT Login.user_id, Login.security_code from Login inner join Users on Users.Id = Login.user_id 
            where Users.phone = :phone',array(':phone' => $param)) :
            $this->Select('SELECT user_id, security_code, Users.name, Users.lastname from Login inner join Users on Users.Id = Login.user_id 
            where Users.email = :email',array(':email' => $param));
        return ($query != null)? $query : 0;        
    }

    public function login($username)
    {
       $load = new LoadModel('Entities/Login');
        $query = $this->Select("SELECT Id,password,name,lastname from Login inner join Users 
        on Users.Id = Login.user_Id where nickname = :username",array(':username' => $username ));
        return $query;
    }

   public function __getRoleById($user_id){
       $data = array(':user_id' =>$user_id);
       $roles = $this->Select("SELECT role_name from Role inner join User_Role 
       on User_Role.role_Id = Role.role_id where User_Role.user_id = :user_id",$data);
       return implode(',',$roles);        
    }

    public function updateCode($code, $id){
        $updated = $this->Update("UPDATE Login set security_code = :new_code where user_id = :id",array(':new_code' =>$code,':id'=>$id));
        return $updated;
    }

    public function changePassword($newPassword,$id){
        $oldPassword = $this->Select("SELECT password from Login where user_id = :id",array(':id' =>$id));
        if (!password_verify($newPassword,$oldPassword[0])) {
            $password = password_hash(htmlspecialchars($newPassword),PASSWORD_BCRYPT);
            $this->Update("UPDATE Login set password = :newPassword where user_id = :id ",array(':newPassword'=>$password,':id'=>$id));
            return true;
        }else{
            return false;
        }
    }
    
    public function Register(Users $user, Login $login, User_Role $role_user){
        try{
            //User
            $id= $user->getId();
            $name = $user->getName();
            $lastname = $user->getLastname();
            $address = $user->getAddress();
            $email = $user->geteMail();
            $phone = $user->getPhone();
            $picture = $user->getPicture();            
           
            #Checking if the new user already exists
            $query = $this->Select("SELECT * from Users where email = :email",array(':email'=>$email));
            if($query == null){
                //Inserting in Users
                $data = array(':id_user' => $id,':username'=>$name,':lastname'=>$lastname,
                ':user_address'=>$address,':email'=>$email,':phone'=>$phone);
                $this->Insert('Users',$data);

                //Inserting picture
                $sql = "INSERT into Images values(NEWID(),:user_id,:picture)";
                $query = $this->pdo->prepare($sql);
                $query->bindParam(':user_id',$id,PDO::PARAM_STR);
                $query->bindParam(':picture',$picture,PDO::PARAM_LOB,0,PDO::SQLSRV_ENCODING_BINARY);
                $query->execute();
                
                //Login
                $nickname = $login->__get('username');
                $pass = $login->__get('password');
                $secure = $login->__get('security_code');
                $connected = $login->__get('connected');

                //Inserting in Login
                $data = array(':id_user' =>$id,':nickname'=>$nickname,':user_password'=>$pass,
                ':security_code'=>$secure,':connected'=>$connected);
                $this->Insert('Login',$data);

                //Role
                $role_id = $role_user->__get('role_id');
                //Inserting in User_Role
                $data = array(':user_id' =>$id,':role_id'=>$role_id);
                $this->Insert('User_Role',$data);
                return 0;        
            }else{
                return 1;
            }
           
        }catch(PDOException $e){
            return $e->getMessage();
        }
    }

    function get_User_Image($id){
        $stmt = $this->pdo->prepare('Select Picture from Images where user_id = :id');
        $stmt->bindParam(':id',$id,PDO::PARAM_STR);
        $stmt->execute();
        $stmt->bindColumn(1,$image,PDO::PARAM_LOB);
        $stmt->fetch(PDO::FETCH_BOUND);
        
        return $image;
    }
}
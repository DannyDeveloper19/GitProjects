<?php
class Login{
    private $user_id;
    private $username;
    private $password;
    private $security_code;
    private $connected;

    public function __construct($user_id,$username,$password,$security_code,$connected)
    {
        $this->user_id = $user_id;
        $this->username = $username;
        $this->password = $password;
        $this->security_code = $security_code;
        $this->connected = $connected;
    }

    public function __get($field_to_read){
        return $this->$field_to_read;
    }

    public function __set($field_to_set,$value_to_set)
    {
        $this->$field_to_set = $value_to_set;
    }

}
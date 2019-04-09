<?php
class User_Role
{
    private $user_id;
    private $role_id;

    public function __construct($user_id,$role_id)
    {
        $this->user_id = $user_id;
        $this->role_id = $role_id;
    }

    public function __get($field_to_read){
        return $this->$field_to_read;
    }

    public function __set($field_to_set,$value_to_set)
    {
        $this->$field_to_set = $value_to_set;
    }
}
<?php
class Role
{
    private $id;
    private $role_name;
    //private $privileges;

    public function __construct($id,$role_name,$privileges)
    {
        $this->id = $role_id;
        $this->role_name = $role_name;
        // binary number c-r-u-d
        //$this->privileges = $privileges;
    }

    public function __get($field_to_read){
        return $this->$field_to_read;
    }

    public function __set($field_to_set,$value_to_set)
    {
        $this->$field_to_set = $value_to_set;
    }
}

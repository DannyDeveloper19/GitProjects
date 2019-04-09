<?php
class Users{
    private $id;
    private $name;
    private $lastname;
    private $address;
    private $email;
    private $phone;
    private $picture;

    public function __construct($id,$name,$lastname,$address,$email,$phone,$picture = null)
    {
        $this->id = $id;
        $this->name = $name;
        $this->email = $email;
        $this->lastname = $lastname;
        $this->address = $address;
        $this->phone = $phone;
        $this->picture = $picture;
    }
    // IdUser
    public function getId():string
    {
        return $this->id;
    }
    public function setId(string $id)
    {
        $this->id = $id;
    }
    //Name
    public function getName():string
    {
        return $this->name;
    }
    public function setName(string $name)
    {
        $this->name = $name;
    }
    //lastname
    public function getLastname():string
    {
        return $this->lastname;
    }
    public function setLastname(string $lastname)
    {
        $this->lastname= $lastname;
    }
    //eMail
    public function geteMail():string
    {
        return $this->email;
    }
    public function seteMail(string $email)
    {
        $this->email= $email;
    }
    //address
    public function getAddress():string
    {
        return $this->address;
    }
    public function setAddress(string $address)
    {
        $this->address= $address;
    }
    //Phone
    public function getPhone():string
    {
        return $this->phone;
    }
    public function setPhone(string $phone)
    {
        $this->phone= $phone;
    }
    //Picture
    public function getPicture()
    {
        return $this->picture;
    }
    public function setPicture($picture)
    {
        $this->picture= $picture;
    }
}
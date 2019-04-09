<?php
class LoginHistory{
    private $login_id;
    private $detail_id;
    private $ip_client;
    private $mac_client;
    private $sign_in;
    private $sign_out;

    public function __construct($login_id,$sign_up_date,$ip_client,$mac_client, $sign_in,$sign_out)
    {
        $this->login_id = $login_id;
        $this->detail_id = $detail_id;
        $this->ip_client = $ip_client;
        $this->mac_client = $mac_client;
        $this->sign_in = $sign_in;
        $this->sign_out = $sign_out;
    }

    public function get_User_Id(){
        return $this->user_id;
    }
    public function set_User_Id($user_id){
        $this->user_id = $user_id;
    }

    public function get_Sign_Up_Date(){
        return $this->sign_up_date;
    }
    public function set_Sign_Up_Date($sign_up_date){
        $this->sign_up_date = $sign_up_date;
    }

    public function get_Ip_Client(){
        return $this->ip_client;
    }
    public function sget_Ip_Client($ip_client){
        $this->ip_client = $ip_client;
    }

    public function get_Mac_Client(){
        return $this->mac_client;
    }
    public function sget_Mac_Client($mac_client){
        $this->mac_client = $mac_client;
    }
    
    public function get_Sign_In(){
        return $this->sign_in;
    }
    public function set_Sign_In($sign_in){
        $this->sign_in = $sign_in;
    }

    public function get_Sign_Out(){
        return $this->sign_out;
    }
    public function set_Sign_Out($sign_out){
        $this->sign_out = $sign_out;
    }
}
<?php

class Session
{
    static function authenticated($signed = false){
         $_SESSION['Signed'] = $signed;
    }

    static function __start()
    {
        @session_start();
    }

    static function getSession($name){
        return (isset($_SESSION[$name])) ?$_SESSION[$name]:'';
    }

    static function setSession($name,$data){
        $_SESSION[$name] = $data;
    }
    
    static function __destroy(){
        @session_destroy();
    }
}

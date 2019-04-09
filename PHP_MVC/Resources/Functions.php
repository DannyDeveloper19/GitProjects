<?php
function url_Base()
{
    return "http://".$_SERVER['SERVER_NAME']."/PHP_MVC";
}
function get_Url($controller, $action = "")
{
    echo ($action == "")? "PHP_MVC/".$controller."/index/0" : "/".$controller."/".$action;    
}
function authenticated(){
    return ($_SESSION && isset($_SESSION['User']))? true : false;
    
}

function isInRole($role){
    if(isset($_SESSION['Role'])){
        $user_role = base64_decode($_SESSION['Role']);
        if (count($role) == 1) {
            return ($user_role == $role) ? true : false ;
        }
        elseif (count($role) == 0) {
            return false;
        }
        else {
            $i = 0;
            $allow = false;
            while ($i < count($role)) {
                if($role[$i]==$user_role)
                    $allow = true;
                $i++;
            }
            return $allow;
        }
    }else{
        return false;
    }
}

function get_Icon($code, $size= null)
{
    $icon =($size != null)? '<i style="font-size:'.$size.'em" class="fa fa-'.$code.'" aria-hidden="true"></i>':'<i class="fa fa-'.$code.'" aria-hidden="true"></i>';
    return $icon;
}

function get_Date(){
    $time = time();
    return date('l, F jS Y, h:i:s A');
}


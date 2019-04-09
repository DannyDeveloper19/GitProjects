<?php
class Controller
{
    public function __construct()
    {
        
        if ($_GET && isset($_GET['action'])) 
        {
            $action = $_GET['action'];
            if (method_exists($this,$action)) 
            {
                if(isset($_GET['data']))
                    $this->$action(($_GET['data']));
                else
                $this->$action();
            }
            else 
            {
                echo "Site not found";
            }
        }
        else 
        {
            if (method_exists($this,"index"))
                $this->index();
        }
    }
}
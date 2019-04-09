<?php
class Layout
{
    public function __construct($view,$data)
    {
        if(file_exists("./Views/$view"))
        {
            if ($data == 1) {
                require("./Views/$view");
            }else {
                $header = "header.php";
                $footer = "footer.php";         
                if(file_exists("./Views/Share/$header"))require("./Views/Share/".$header); else die("Header not found");
                require("./Views/$view");
                if(file_exists("./Views/Share/$footer"))require("./Views/Share/".$footer); else die("Footer not found");
            }
           
        }
        else
        {
            die("Site not found");
        }
    }
}
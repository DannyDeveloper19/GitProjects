<?php
class View {
    public function __construct($view,$data = null)
    {
        if (file_exists("./Views/$view")){
            $layout = new Layout($view,$data);
        }else 
            die("View not found");
        
    }
}
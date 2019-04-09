<?php
class Manage extends Controller{
    public function __construct()
    {
        if(isInRole('admin'))
            parent::__construct();
        else
            header("Location: ".url_Base());
    }
    public function index()
    {
        $view = new View("Manage/index.php");
    }
}
<?php
class User extends Controller
{
    public function __construct()
    {
        if(isInRole(['admin','guess']))   
            parent::__construct();
        else 
            header("Location: ".url_Base());     
    }
    
    public function index($id)
    {
        $id = base64_decode($id);
        $load = new LoadModel("UserModel");
        $userModel = new UserModel();
        $user = $userModel->select_Users($id);
        $view = new View("Guess/index.php",compact("user"));

    }
}
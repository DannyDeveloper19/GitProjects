<?php
class Home extends Controller
{
    public function __construct()
    {
        parent::__construct();
    }

    public function index()
    {
        $session = Session::getSession('User');
        if ($session != '')
            header("Location: ".url_Base()."/Guess/index/".$session);
        else
            $start = new View("Home/home.php");
    }

    public function about()
    {
        $start = new View("Home/about.php");
    }

    public function contact()
    {
        $start = new View("Home/contact.php");
    }
}

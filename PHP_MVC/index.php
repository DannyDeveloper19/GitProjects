<?php
require('App_Start/Controller.php');
require('App_Start/Loader.php');
require('App_Start/View.php');
require('App_Start/Layout.php');
require('App_Start/Model.php');
require('App_Start/Mailer.php');
require('Config/globals.php');
require('Config/Sessions.php');
require('Resources/CSRF.php');
require('Resources/Functions.php');
require('Resources/Mail.php');


//Preventing a Directory Traversal attack
$index_controller = $_GET['controller'] ?? "Home";
$index_controller = (in_array($index_controller, $allowed_directories)) ? $index_controller : "Home";

Session::__start();        
require(__DIR__."/Controllers/".$index_controller."Controller.php");       

$obj = new $index_controller();


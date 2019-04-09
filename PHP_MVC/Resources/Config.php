<?php
#region Default Controller
$index_controller = "Home";
#endregion

#region Connection to database
class DBModel
{
    public $pdo;
    public function __construct()
    {
        //Credentials
        $host = "DANNYLAPTOP\SQLEXPRESS";
        $user = "root";
        $pass = "root1";
        $database = "Id_System";
        
        //Creating connection to SQL Server
        $dns = "sqlsrv:Server={$host};Database={$database}";
        $opt = [PDO::ATTR_DEFAULT_FETCH_MODE=>PDO::FETCH_ASSOC];
        $this->pdo = new PDO($dns,$user,$pass,$opt);
        $this->pdo->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
 
    }
}
#endregion

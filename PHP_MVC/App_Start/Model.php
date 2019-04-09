<?php
class Model
{
    public $pdo;
    public function __construct()
    {
        $db_cfg = require_once('Config/database.php');
        $host = $db_cfg['host'];
        $user = $db_cfg['user'];
        $pass = $db_cfg['pass'];
        $database = $db_cfg['database'];
        
        //Creating connection to SQL Server
        try{
            $dns = "sqlsrv:Server={$host};Database={$database}";
            $opt = [PDO::ATTR_DEFAULT_FETCH_MODE=>PDO::FETCH_ASSOC];
            $this->pdo = new PDO($dns,$user,$pass,$opt);
            $this->pdo->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
        }catch(PDOException $e){
            die("Connection failed: ".$e->getMessage());
        }
         
    }

    public function getPDO(){
        return $this->pdo;
    }

    public function Insert($table,$data){
        $sql = "INSERT into ".$table." values(";
        $lenght = count($data);
        foreach ($data as $key => $value) {
            if($lenght == 1)
                $sql .= $key.');';
            else
                $sql .= $key.', ';
            $lenght--;
        }
        $query = $this->pdo->prepare($sql);
        $query->execute($data);
    }

    public function InsertFileStream(){}

    public function Select($sql_query,$data = null){
        if($data != null){
            $query = $this->pdo->prepare($sql_query);
            $query->execute($data);
            $result = $query->fetch();
            if ( !empty($result)) {
                foreach ($result as $row) {
                    $response[] = $row;
                }
                return $response;
            }
        }else{
            return $this->pdo->query($sql_query);
        }

        
    }

    public function Update($sql_query,$data){
        $query = $this->pdo->prepare($sql_query);
        $query->execute($data);
        return true;
    }

    public function Delete($sql,$data){
        $query = $this->pdo->prepare($sql);
        $query->execute($data);
        return true;
    }
}
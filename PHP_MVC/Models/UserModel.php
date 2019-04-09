<?php
class UserModel extends Model
{
    public function __construct()
    {
        parent::__construct();
    }

   public function select_Users($id = null)
    {
        $load = new LoadModel('Entities/User');
        $usersLists = [];
        if ($id != null) {
            $query = $this->Select("SELECT * from Users where Id =:id order by name ASC",array(':id' => $id));
            return new Users($query[0],$query[1],$query[2],$query[3],$query[4],$query[5],$query[6]);
        }else{
            $query = $this->Select("SELECT * from Users order by name ASC");
            foreach ($query as $row) 
            {
                $user = new Users($row['Id'],$row['name'],$row['lastname'],$row['address'],$row['email'],$row['phone']);
                array_push($usersLists,$user);
            }
            return $usersLists;
        }
    }

    public function delete_User($id){
        $query = $this->Delete("DELETE from Images where user_Id = :id",array(':id'=>$id)) &&
        $this->Delete("DELETE from Login where user_id = :id",array(':id'=>$id)) &&
        $this->Delete("DELETE from User_Role where user_id = :id",array(':id'=>$id)) &&
        $this->Delete("DELETE from Users where Id = :id",array(':id'=>$id));
        return $query;
    }

}
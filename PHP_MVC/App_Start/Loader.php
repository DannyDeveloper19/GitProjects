<?php
class LoadModel
{
    public function __construct($model)
    {
        require("./Models/$model.php");
    }
}
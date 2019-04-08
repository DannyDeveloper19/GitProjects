<?php include('Php/functions.php')?>
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <script src="_jQuery/jquery.min.js">
        <script src="_jQuery/jquery-3.2.1.min.js"></script>
        <script src="_jQuery/jquery-1.9.1.js"></script>
        <script src="_jQuery/boostrap.min.js"></script>
        
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <link rel="stylesheet" href="fontawesome-free-5.0.4\web-fonts-with-css\css\fontawesome-all.css">
        <title>Ajax,JQuery,Php</title>
    </head>
    <body>
        <div class="container-fluid">
            <header class="row">
                <div class="col-6">
                    <a href="#">Enter Restore Mode</a>
                </div>
                <div class="col-6 text-right">
                    Total Time: <span id="tally"></span>
                </div>
            </header>
            <div class="row">
                <form id="form-new" class="form-control">
                    <div class="col-12">
                        <input type="text" name="task" id="task" class="form-control" placeholder="Enter new task name...">
                    </div>
                    <div class="col-2">
                        <button type="submit" class="btn btn-block btn-success"><?=get_Icon('play')?></button>
                    </div>          
                </form>     
            </div>
            <hr>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Task</th>
                        <th>Start</th>
                        <th>End</th>
                        <th>Time</th>
                        <th colspan="2">Controls</th>
                    </tr>
                </thead>
                <tbody id="server"></tbody>
            </table>
        </div>
    
        <script src="js/ajax_jquery_php.js"></script>
    </body>
</html>
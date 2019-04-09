<!DOCTYPE html>
<html lang="en">
<head>
    <base href=<?php echo url_Base();?> />
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="PHP_MVC/Content/css/bootstrap.min.css" type="text/css"/>
    <link rel="stylesheet" href="PHP_MVC/Content/css/bootstrap.theme.min.css" type="text/css"/>
    <link rel="stylesheet" href="PHP_MVC/Content/css/design.min.css" type="text/css"/>
    <link rel="stylesheet" href="PHP_MVC/Content/fontawesome-free-5.0.4/web-fonts-with-css/css/fontawesome-all.css" type="text/css"/>


    <!-- <script src="PHP_MVC/Content/_jquery/boostrap.min.js" type="text/javascript"></script> -->
    <script src="PHP_MVC/Content/_jquery/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="PHP_MVC/Content/_jquery/jquery.validate.min.js" type="text/javascript"></script>    
    <script src="PHP_MVC/Content/js/functions.min.js" type="text/javascript"></script>
    <script src="PHP_MVC/Content/js/webservice.js" type="text/javascript"></script>
    <title>MVC</title>
</head>

<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
            <div class="collapse navbar-collapse">
                <?php 
                        if (authenticated()) {
                            echo '<form class="form-inline mr-auto" >
                                    <input class="form-control mr-sm-2" type="text" placeholder="Search"> 
                                    <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
                                </form>'; 
                        } else {
                            echo '<div class="navbar-nav mr-auto">
                                    <div class="btn-primary">
                                        <a class="nav-link" href="'.url_Base().'/Home/index/0">'.get_Icon("home").'   Home</a>
                                    </div>
                                    <div class="btn-primary">
                                        <a class="nav-link" href="'.url_Base().'/Home/about/0">'.get_Icon("info").'   About</a>
                                    </div>
                                    <div class="btn-primary">
                                        <a class="nav-link" href="'.url_Base().'/Home/contact/0">'.get_Icon("envelope").'   Contact</a>
                                    </div>                    
                                </div>';
                        }
                        
                    ?>
                
                <div class="navbar-nav my-2 my-lg-0">
                    <?php
                        if (authenticated()) {
                            $img = Session::getSession('Picture');
                            if($img != null){
                               echo "<div class=''><img src='data:image/jpg;base64,".base64_encode($img)."' alt='user' style='width:60px;height:60px;border-radius:50%;'/></div>";
                            }else {
                                echo "<div class=''><img src='".url_Base()."/Content/images/uknown_user.png' alt='uknown' style='width:60px;height:60px;border-radius:50%;'></div>";
                            }
                            echo "<div class=''><a class='nav-link dropdown-toggle' href='".url_Base()."/Profile/index/".Session::getSession('User')."'>".base64_decode(Session::getSession('Name'))."</a></div>";
                            echo " <div class='btn-primary'>
                                <a class='nav-link' id='sign-out'>".get_Icon('sign-out-alt')."Sign out</a>
                                </div>";
                        }else {
                            echo " <div class='btn-primary'>
                                <a class='nav-link' id='new_register' href='".url_Base()."/Account/register/1'>".get_Icon('user-plus')." Register</a>
                                </div>";
                            echo " <div class='btn-primary'>
                                <a class='nav-link' id='sign-in' href='".url_Base()."/Account/login/1'>".get_Icon('sign-in-alt')." Sign in</a>
                                </div>";
                        }
                    ?>
                   
                </div>
                <!-- <form class="form-inline my-2 my-lg-0">
                    <input class="form-control mr-sm-2" type="text" placeholder="Search">
                    <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
                </form>  -->                 
            </div> 
        </nav>
    
   <div class="main">
   
   


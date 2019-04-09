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


    <script src="PHP_MVC/Content/_jquery/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="PHP_MVC/Content/_jquery/jquery.validate.min.js" type="text/javascript"></script>    
    <script src="PHP_MVC/Content/js/functions.min.js" type="text/javascript"></script>
    <script src="PHP_MVC/Content/js/validations.min.js" type="text/javascript"></script>
    <title>Sign In</title>
</head>
<body>
  <div class="alert-notice" id="notice"></div>
  <div class="login">
      <div class="box-header"><a href="PHP_MVC/Home/index/0"><?php echo get_Icon("home");?></a></div>

    <form method="POST" id="Session" name="Session" style="margin-top:20px;padding-right:40px;padding-left:40px;">
        <!--Preventing CSRF attack-->
      <input type="hidden" name="_token" value="<?php echo NoCSRF::generate('_token');?>">
        <div class="form-group has-success">
            <input class="form-control" type="text" name="username" id="userlogin" placeholder="User">
            <div class="valid-feedback" id="userValidate"></div>
        </div>
        <div style="margin-top:20px;">
          <input class="form-control" type="password" name="password" id="passlogin" placeholder="Password">
          <div class="valid-feedback" id="passValidate"></div>
        </div>
        <div>
        <div class="custom-control custom-checkbox" style="margin-top:20px;margin-left:10px;">
          <input class="custom-control-input" id="customCheck1" type="checkbox">
          <label class="custom-control-label" for="customCheck1">Remember me</label>
        </div>      
        <button type="button" id="session-sign-in" style="margin-left:35%;margin-top:10px;" class="btn btn-success btn-lg"><?php echo get_Icon("sign-in-alt");?>  Sign in</button>
         </div>
    </form>
      <br/>
      <a class="forgot" href="PHP_MVC/Account/register/1"><?php echo get_Icon("user-plus");?>New Account</a>
      <br/>
      <a class="forgot" href="PHP_MVC/Account/changePassword/1">Forgot Username/Password?</a>    
  </div>
  <p style="padding-left: 42.5%;margin-top:10px;"><?php echo get_Date();?></p>
</body>
</html>
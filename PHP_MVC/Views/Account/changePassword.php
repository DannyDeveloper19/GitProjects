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
    <title>Change Password</title>
</head>
<body>
    <div class="reset">
    <form id="frm_changePassword" action="" method="POST" style="margin-top:60px;padding-right:40px;padding-left:40px;">
        <input type="hidden" name="_token" value="<?php echo NoCSRF::generate('_token');?>">
        <div class="form-group">
            <input class="form-control" type="password" name="pss_newPassword" id="newPassword" placeholder="New password">
        </div>
        <div class="form-group">
        <input class="form-control" type="password" name="pss_confirmPassword" id="" placeholder="Confirm password">
        </div>
        <div class="form-control">
        <input type="submit" style="margin-left:15%;margin-top:10px;" value="Change Password" class="btn btn-success btn-lg">
        </div>
    </form>
    </div>
</body>
</html>
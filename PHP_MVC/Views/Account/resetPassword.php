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
    <title>Forgot Password</title>
</head>
<body>
    <div id="div_resetPassword" class="reset">
        <h4 style="margin-top:50px; padding-lef:10px;">To change your password you will receive a code, select the way of your preference:</h4>
        <!--<div class="card border-danger mb-3" id="rd_selection"></div>-->
        <form action="" id="frm_resetPassword"  method="POST" style="margin-top:30px;padding-right:40px;padding-left:40px;">
            <input type="hidden" name="_token" value="<?php echo NoCSRF::generate('_token');?>">
            <div class="form-group">
               <div class="custom-control custom-radio">
                    <input name="rd_reset" class="custom-control-input" id="resetByEmail" type="radio">
                    <label class="custom-control-label" for="resetByEmail"><?php echo get_Icon("envelope");?> Send by email</label>
                    </div>
                    <div class="custom-control custom-radio">
                    <input name="rd_reset" class="custom-control-input" id="resetByText" type="radio">
                    <label class="custom-control-label" for="resetByText"><?php echo get_Icon("mobile");?> Send by text</label>
                </div>
            </div>
            <div class="form-group has-success">
                <input class="form-control" type="text" name="txt_reset" id="txt_reset">
                <div class="valid-feedback" id="txt_notice"></div>
            </div>
            <div>
                <button type="submit" id="btn_resetPassword" style="margin-left:25%;margin-top:10px;" class="btn btn-success btn-lg"><?php echo get_Icon("paper-plane");?>  Send code</button>
            </div>
        </form>
    </div>
    <div id="div_changePassword" class="changePassword">
        <h4 style="margin-top:50px; margin-left:100px;">Insert the code sent</h4>
        <form id="frm_Verification" action="" method="post" style="margin-top:30px;padding-right:40px;padding-left:40px;">
            <div class="form-group has-success">
                <input class="form-control" type="text" name="txt_code" id="txt_code" style="text-align:center">
            </div>
            <div>
                <button type="submit" id="btn_verifyPassword" style="margin-left:33%;margin-top:10px;" class="btn btn-success btn-lg"><?php echo get_Icon("key");?>  Verify</button>
            </div>
        
    </form>
    </div>
</body>
</html>
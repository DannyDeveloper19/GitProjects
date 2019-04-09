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
    <script src="PHP_MVC/Content/js/validations.min.js" type="text/javascript"></script>
    <script src="PHP_MVC/Content/js/FileUpLoader.js" type="text/javascript"></script>
    <title>New Account</title>
</head>
<body>

<div class="overlay"></div>
<div class="forms-slide">
<div class="alert-notice" id="alert_register"></div>
<form method="POST" class="forms" id="register_user" name="register_user" enctype="multipart/form-data">
<input type="hidden" name="_token" value="<?php echo NoCSRF::generate('_token');?>">
<ul class="nav nav-pills flex-column" style="border-bottom:2px solid #2196f3;">
      <li class="nav-item">
            <a class="nav-link active" id="show_register"><?php echo get_Icon('arrow-circle-right')?>  Register</a>
            <div id="form_register">
                  <div class="form-group first">
                        <div>
                              <input class="form-control" name="name" id="name" type="text" placeholder="Enter your name..." required>
                              <div id="name-error"></div>
                        </div>
                        <div>
                              <input class="form-control" name="lastname" id="lastname" type="text" placeholder="Enter your lastname..." required>
                              <div id="lastname-error"></div>
                        </div>
                  </div>
                  <div class="form-group">
                        <div class="address">
                              <input class="form-control" style="width:55%" name="street" id="street" type="text" placeholder="Street..." required>
                              <input class="form-control" name="county" id="county" type="text" placeholder="County" required>
                              <input class="form-control" name="state" id="state" type="text" placeholder="State" required>
                              <input class="form-control" name="zipcode" id="zipcode" type="text" placeholder="Zipcode" required>
                        </div>
                  </div>
                  <div class="first">
                        <div class="form-group">
                              <input class="form-control" name="email" id="email" type="email" placeholder="Enter your email..." required>
                              <div id="email-error"><small><?php echo get_Icon("exclamation-triangle");?>username@example.com</small></div>
                        </div>
                        <div class="form-group">
                              <input class="form-control" name="phone" id="phone" maxlength=13 type="text" placeholder="Enter your phone number..." required>
                              <div id="phone-error"><small><?php echo get_Icon("exclamation-triangle");?> (XXX) XXX-XXXX</small></div>
                        </div>
                  </div>
            </div>
      </li>
      <li class="nav-item">
            <a class="nav-link active" id="show_credentials"><?php echo get_Icon('arrow-circle-right')?>  Credentials</a>
            <div id="form_credentials">
                  <div class="form-control">
                        <input class="form-control is-valid" type="text" name="username" id="username" placeholder="Enter your username" required>
                        <div class="notice_feedback" id="username_notice"><?php echo get_Icon("exclamation-triangle");?>Use the username of your email: username@example.com</div>
                  </div>
                  <div class="password">
                        <div class="form-control">
                              <input class="form-control" type="password" name="password" id="password" placeholder="Password" required>
                                    
                        </div>
                        <div class="form-control">
                              <input class="form-control" type="password" name="confirmpassword" id="confirmpassword" placeholder="Confirm password" required>
                                   
                        </div>
                       
                  </div>
            </div>
      </li>
      <li class="nav-item">
            <a class="nav-link active" id="show_picture"><?php echo get_Icon('arrow-circle-right')?>  Picture</a>
            <div id="form_picture" style="margin-left:270px; margin-top:10px;">
                  <div class="picture_taken">
                        <img src="" id="img_load" style="margin-left:-8px;margin-top:-1px;width:180px;height:205px;">                        
                  </div>
                  <div style="margin-left:-1px;padding-top:3px;">
                        <label class="btn btn-outline-primary btn-sm uploader" style="margin-top:8px;">
                              <?php echo get_Icon('upload')?> Upload
                              <input type="file" accept="image/*" name="picture" id="picture">
                        </label>
                        <label id="capture_picture" class="btn btn-outline-primary btn-sm" style="margin-top:8px;">
                              <?php echo get_Icon('camera')?> Camera
                        <input type="text" name="livepicture" id="livepicture" style="display:none;">
                        </label>
                        <!--<button type="button" id="capture_picture" class="btn btn-outline-primary btn-sm"> Camera</button>-->
                  </div>
                  
            </div>
      </li>
</ul>

<div class="button-form" style="margin-top:10px;">
      <button class="btn btn-danger" type="button" id="cancel">Cancel</button>
      <button class="btn btn-success" type="submit">Submit</button>
</div>
</form>
</div>
</body>
</html>
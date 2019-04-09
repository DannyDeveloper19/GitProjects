   <!DOCTYPE html>
   <html lang="en">
   <head>
      <base href=<?php echo url_Base();?> />
      <meta charset="UTF-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <meta http-equiv="X-UA-Compatible" content="ie=edge">
      <link rel="stylesheet" href="PHP_MVC/Content/css/camera_design.css" type="text/css"/>
    
      <script src="PHP_MVC/Content/_jquery/jquery-3.3.1.js" type="text/javascript"></script>
      <script src="PHP_MVC/Content/js/Image.js" type="text/javascript"></script>
     <title>Live Capture</title>
   </head>
   <body>
    <div class="container">
        <div class="app">

            <a href="#" id="start-camera" class="visible">Touch here to start the app.</a>
            <video id="camera-stream"></video>
            <img id="snap">

            <p id="error-message"></p>

            <div class="controls">
            <a href="#" id="delete-photo" title="Delete Photo" class="disabled"><i class="material-icons">replay</i></a>
            <a href="#" id="take-photo" title="Take Photo"><i class="material-icons">camera_alt</i></a>
            <a href="#" id="download-photo" download="selfie.png" title="Save Photo" class="disabled"><i class="material-icons">done</i></a>  
            </div>

            <!-- Hidden canvas element. Used for taking snapshot of video. -->
            <canvas></canvas>

        </div>

    </div>
   </body>
   </html>
   

  
<?php
class eMail{

   static function sendMail($to,$toName = '',$Subject,$message)
    {
        $email = new PHPMailer();
        $email->CharSet = "utf-8";
        $email->SMTPDebug = 0;
        $email->IsSMTP();
        $email->SMTPSecure = "ssl";  
        $email->Host = "smtp.gmail.com";
        $email->Port = "465";
        $email->SMTPAuth = true;
        $email->FromName = "Php Developer";
        $email->Username = "php7mvc.developers@gmail.com";
        $email->Password = "Admin.1234";
        $email->From = "php7mvc.developers@gmail.com";
        $email->addAddress($to,$toName);
        $email->Subject = $Subject;
        $email->isHTML(true);
        $email->Body = $message;

        if($email->send()){
            return true;
        }
        else
        {
            $json = json_encode("Error: ".$email->ErrorInfo);
            $file = fopen('./Content/tmp/console_log.json','w') or die("Error: Open file failed");
            if($file){
                fwrite($file,$json);
                fclose($file); 
            }  
            return false;        
        }  
    }

    static function sendText($number,$subject,$message){
        $phone = substr($number,1,3).substr($number,5,3).substr($number,9,strlen($number));
        $text = new PHPMailer();
        $text->CharSet = "utf-8";
        $text->SMTPDebug = 0;
        $text->IsSMTP();
        $text->SMTPSecure = "ssl";  
        $text->Host = "smtp.gmail.com";
        $text->Port = "465";
        $text->SMTPAuth = true;
        $text->FromName = "Php Developer";
        $text->Username = "php7mvc.developers@gmail.com";
        $text->Password = "Admin.1234";
        $text->From = "php7mvc.developers@gmail.com";
        $text->Subject = $subject;
        $text->addAddress($phone."@mymetropcs.com");
        $text->Body = $message;
        if($text->send())
            return true;
        else{
            $json = json_encode("Error: ".$text->ErrorInfo);
            $file = fopen('./Content/tmp/console_log.json','w') or die("Error: Open file failed");
            if($file){
                fwrite($file,$json);
                fclose($file); 
            }  
            return false;       
        }
    }
   
}
?>
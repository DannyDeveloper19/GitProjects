<?php
//Return a FontAwesome icon
function get_Icon($code)
{
    $icon = '<i class="fa fa-'.$code.'"></i>';
    return $icon;
}
//Return the date with a specific format
function get_Date($date){
    return date('M j Y g:i A',$date);
}
//Return the time in hours and minutes
function get_Time($seconds){
    $h = floor(($seconds/60)/60);//Get hours
    $m = round(($seconds/60) - ($h * 60));//Get minutes

    return $h.' hrs: '.$m.' mins';
}

function save_Task($file_json,$data){
    $time = $data['id'];
    $file_json[$time]['id'] = $data['id'];
    $file_json[$time]['name'] = $data['name'];
    $file_json[$time]['date_start'] = $data['date_start'];
    $file_json[$time]['date_end'] = $data['date_end'];
    $file_json[$time]['status'] = $data['status'];
    
    $json = json_encode($file_json);
    $file = fopen("../JSON/text.json","w") or die("Error: Open file failed;");
    fwrite($file,$json);
    fclose($file);
}
?>
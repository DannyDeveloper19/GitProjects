<?php
include('functions.php');
$json = file_get_contents('../JSON/text.json');
$array = json_decode($json,true);

switch ($_GET['mode']) {
    case 'build':
       foreach ($array as $task) {?>
<tr>
    <th><?=$task['name']?></th>
    <th><?=get_Date($task['date_start'])?></th>
    <th>
        <?php 
        if ($task['date_end'] !="") {
            echo get_Date($task['date_end']);
        }
        ?>
    </th>
    <th>
        <?php
        if ($task['date_end'] == "") {
            echo get_Time(time()-$task['date_start']);
        }
        else {
            echo get_Time($task['date_end']-$task['date_start']);
        }
        ?>
    </th>
    <th><button class="btn btn-primary"><?=get_Icon('stop')?></button></th>
    <th><button class="btn btn-danger"><?=get_Icon('times')?></button></th>
</tr>
<?php }
        break;

    case 'tally':
        $count=0;
        foreach ($array as $task) {
            if ($task['date_end'] != "") 
                $count = $count + ($task['date_end'] - $task['date_start']);
            else
                $count = $count +(time() - $task['date_start']);
        }
        echo get_Time($count);
        break;

    case 'new':
        $time = time();
        $data['id'] = $time;
        $data['name'] = $_GET['task'];
        $data['date_start'] = $time;
        $data['date_end'] = 0;
        $data['status'] = 1;
        save_Task($array,$data);
        break;

    default:
        # code...
        break;
}




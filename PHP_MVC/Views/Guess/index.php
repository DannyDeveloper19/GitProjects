<table class="table table-hover">
<tr>
<th scope="col">Name</th>
<th scope="col">eMail</th>
</tr>
<?php
foreach ($data['users'] as $row) {
    echo '<tr><td> '.$row->getName().
    '</td><td>'.$row->geteMail()."</td><td><button id='".$row->getId()."' class='btn btn-outline-primary' style='margin-right:5px;'>".get_Icon('edit')."</button><button id='".$row->getId()."' class='btn btn-outline-danger remove'>".get_Icon('trash')."</button></td></tr>";
}
/* echo '<tr><td> '.$row->getName().
    '</td><td> <a href ="'.url_Base().'/Guess/sendEmail/'.$row->geteMail().'">'.$row->geteMail()."</a></td><td><button id='".$row->getId()."' class='btn btn-outline-primary' style='margin-right:5px;'>".get_Icon('edit')."</button><button id='".$row->getId()."' class='btn btn-outline-danger remove'>".get_Icon('trash')."</button></td></tr>";*/
    
?>
</table>

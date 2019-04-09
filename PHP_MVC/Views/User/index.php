<?php
foreach ($data['users'] as $row) {
    echo '<b>Name:</b> '.$row->getName().
    '<br/><b>e_Mail:</b> '.$row->geteMail()."<hr>";

}
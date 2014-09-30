<!DOCTYPE html>
<html>
<head>
    <title>Word mapper</title>
    <meta charset="UTF-8">
    </head>
<body>
<form method="post">
    <textarea name="input" id="input"></textarea><br>
    <input type="submit" value="Count words">
</form>
<?php
if(isset($_POST["input"]) && !empty($_POST["input"])) :

$words = preg_split("/\W+/", strtolower($_POST["input"]), -1, PREG_SPLIT_NO_EMPTY);
$wordMap = array();

foreach($words as $word) {
    if(isset($wordMap[$word])) {
        $wordMap[$word]++;
    }
    else {
        $wordMap[$word] = 1;
    }
}
arsort($wordMap);

echo "<table border=\"1\">";
foreach($wordMap as $word => $count) :
?>
<tr>
    <td><?= $word; ?></td>
    <td><?= $count; ?></td>
</tr>
<?php

endforeach;
 echo "</table>";

endif;
?>
</body>
</html>
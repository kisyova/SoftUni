
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<html>
<head>
    <title>Sum of digits</title>
</head>
<body>
<form method="post">
    <label for="string">Input string: </label>
    <input name="string">
    <input type="submit">
</form>
<?php
if(isset($_POST["string"]) && !empty($_POST["string"])) :
    $string = preg_split('/[ ,]/', $_POST["string"], 0, PREG_SPLIT_NO_EMPTY);
?>
<table border="1">
   <?php
   foreach($string as $num) {
       echo "<tr><td>$num</td><td>";
       if(ctype_digit($num)) {
            echo array_sum(str_split($num));
       }
       else {
           echo "I cannot sum that.";
       }
       echo "</td></tr>";
   }
   ?>
</table>
<?php endif; ?>
</body>
</html>
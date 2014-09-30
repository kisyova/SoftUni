<!DOCTYPE html>
<html>
<head>
    <title>Text colorer</title>
    <meta charset="UTF-8">
    <style type="text/css">
        .red {
            color: red;
        }
        .blue {
            color: blue;
        }
    </style>
</head>
<body>
<form method="post">
    <textarea name="input" id="input"></textarea><br>
    <input type="submit" value="Color text">
</form>
<?php

if(isset($_POST["input"]) && !empty($_POST["input"])) :
    $input = explode(" ", $_POST["input"]);
    $input = str_split(implode(" ", $input));

    for($i = 0; $i < count($input); $i++) {
        if(ord($input[$i]) % 2 == 0) {
            echo "<span class=\"red\">$input[$i]</span>";
        }
        else {
            echo "<span class=\"blue\">$input[$i]</span>";
        }
    }
endif;
?>
</body>
</html>
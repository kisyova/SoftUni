<!DOCTYPE html>
<html>
<head>
    <title>Text filter</title>
    <meta charset="UTF-8">
</head>
<body>
<form method="post">
    <textarea id="text" name="text"></textarea><br>
    <input id="banlist" name="banlist">
    <input type="submit">
</form>
<?php
    if(isset($_POST["text"]) && !empty($_POST["text"])) :
        if(isset($_POST["banlist"]) && !empty($_POST["banlist"])) :
            $banned = explode(", ", $_POST["banlist"]);
            $text = $_POST["text"];
            foreach($banned as $ban) {
                $text = str_replace($ban, str_repeat("*", strlen($ban)), $text);
            }
    echo "<p>$text</p>";
?>
</body>
<?php
endif;
endif;
?>
</html>
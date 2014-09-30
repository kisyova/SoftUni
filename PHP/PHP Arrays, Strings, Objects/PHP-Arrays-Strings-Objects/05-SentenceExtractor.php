<!DOCTYPE html>
<html>
<head>
    <title>sentence extractor</title>
    <meta charset="UTF-8">
</head>
<body>
<form method="post">
    Text:<br>
    <textarea id="text" name="text"></textarea><br>
    Word:<br>
    <input name="word" id="word"><br>
    <input type="submit">
</form>
<?php
if(isset($_POST["text"]) && isset($_POST["word"])) :
    $sentences = preg_split("/(?<=[.?!])\s*/", $_POST["text"], -1, PREG_SPLIT_NO_EMPTY);
    $sentences = array_map("trim", $sentences);

    $word = $_POST["word"];
    foreach($sentences as $sentence) {
        if(preg_match("/\s+$word\s+.*[.?!]+$/", $sentence)) {
            echo "<p>$sentence</p>";
        }
    }
endif;
?>
</body>
</html>
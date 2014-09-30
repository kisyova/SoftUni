<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Most Frequent Tags</title>
</head>
<body>
<form method="post">
    <label for="tags">Enter tags:</label><br/>
    <input type="text" name="tags" id="tags"/>
    <input type="submit" name="submit"><br/><br/>
    <?php
    if ($_POST && isset($_POST["submit"])) {
        $tags = explode(", ", $_POST["tags"]);

        $tagCount = array();
        foreach($tags as $tag) {
            if(!isset($tagCount[$tag])) {
                $tagCount[$tag] = 1;
            }
            else {
                $tagCount[$tag]++;
            }
        }

        arsort($tagCount);
        ?>
    <div id="result">
        <?php
        foreach($tagCount as $key => $value) {
            echo $key . " : " . $value . " time" . ($value == 1 ? "" : "s") . "<br />";
        }
        echo "Most frequent tag is: " . array_keys($tagCount)[0]; ?>
    </div>

    <?php } ?>
</form>
</body>
</html>
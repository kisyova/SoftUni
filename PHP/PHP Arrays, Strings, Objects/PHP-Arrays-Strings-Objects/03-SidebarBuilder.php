<!DOCTYPE html>
<html>
<head>
    <title>Sideba Builder</title>
    <meta charset="UTF-8">
    <style type="text/css">
        aside {
            background-color: #5F9EA0;
            border: 1px solid black;
            border-radius: 15px;
            font-family: Tahoma;
            width: 30%;
            margin: 5px 0px;
            padding: 0px 10px;
        }
        aside a{
            color: inherit;
        }
        hr{
            color: black;
        }
    </style>
</head>
<body>
<form method="post">
    <label for="categories">Categories: </label>
    <input name="categories" id="categories" type="text"><br>
    <label for="tags">Tags: </label>
    <input name="tags" id="tags" type="text"><br>
    <label for="months">Months: </label>
    <input name="months" id="months" type="text"><br>
    <input type="submit" value="Generate">
</form>
<?php
    if(isset($_POST["categories"]) && !empty($_POST["categories"])) :
?>
<aside>
    <h2>Categories</h2>
    <hr>
    <ul>
        <?php
        foreach(explode(". ", $_POST["categories"]) as $category) :
        echo "<li><a href=\"#\">$category</a></li>";
        endforeach;
        ?>
    </ul>
</aside>
<?php endif;

if(isset($_POST["tags"]) && !empty($_POST["tags"])) :
?>
<aside>
    <h2>Tags</h2>
    <hr>
    <ul>
        <?php
        foreach(explode(". ", $_POST["tags"]) as $tag) :
            echo "<li><a href=\"#\">$tag</a></li>";
        endforeach;
        ?>
    </ul>
</aside>
<?php endif;

if(isset($_POST["months"]) && !empty($_POST["months"])) :
?>
<aside>
    <h2>Months</h2>
    <hr>
    <ul>
        <?php
        foreach(explode(". ", $_POST["months"]) as $month) :
            echo "<li><a href=\"#\">$month</a></li>";
        endforeach;
        ?>
    </ul>
</aside>
<?php endif; ?>
</body>
</html>
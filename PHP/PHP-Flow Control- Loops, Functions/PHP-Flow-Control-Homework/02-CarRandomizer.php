<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<html>
<head>
    <title>Rich's people problems</title>
</head>
<body>
    <form method="post">
        <label for="cars">Enter cars</label>
        <input name="cars" type="text">
        <input type="submit" value="Show Cars">
    </form>
<?php

if(isset($_POST["cars"]) && !empty($_POST["cars"])) :
    $cars = preg_split('/[ ,]/', $_POST["cars"], 0, PREG_SPLIT_NO_EMPTY);
    $colors = ["white", "yellow", "orange", "pink", "red", "green", "blue", "purple", "grey", "brown", "black", "silver", "gold"];
    ?>
    <table border="1">
        <thead>
        <tr>
            <td><strong>Car</strong></td>
            <td><strong>Color</strong></td>
            <td><strong>Count</strong></td>
        </tr>
        </thead>
        <tbody>
        <?php foreach($cars as $car): ?>
        <tr>
            <td><?= $car ?></td>
            <td><?= $colors[array_rand($colors)] ?></td>
            <td><?= rand(1, 5) ?></td>
        </tr>
        <?php endforeach; ?>
        </tbody>
    </table>

    <?php endif; ?>
</body>
</html>
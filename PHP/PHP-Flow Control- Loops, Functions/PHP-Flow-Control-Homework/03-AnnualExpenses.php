<?php
function month($i) {
    return date("F", strtotime(date("d-$i-Y")));
}
?>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<html>
<head>
    <title>Annual expenses</title>
</head>
<body>
<form method="post">
<label for="years">Enter number of years: </label>
<input name="years" type="number">
<input type="submit" value="Show costs">
</form>

<?php
    if(isset($_POST["years"]) && !empty($_POST["years"])) :
    $years = $_POST["years"];
    $currentYear = date("Y");
?>
<table border="1">
    <thead>
    <tr>
        <th><strong>Year</strong></th>
        <?php
        for($i = 1; $i <= 12; $i++) {
            echo "<th>" . month($i) . "</th>";
        }
        ?>
        <th><strong>Total</strong></th>
    </tr>
    </thead>
    <tbody>
    <?php
    for($y = $currentYear; $y > $currentYear - $years; $y--) {
        echo "<tr><td>$y</td>";
        $total = 0;
        for($m = 1; $m <= 12; $m++) {
            $currentCost = rand(0, 999);
            echo "<td>" . $currentCost . "</td>";
            $total += $currentCost;
        }
        echo "<td>$total</td></tr>";
    }
    ?>
    </tbody>
</table>
<?php endif; ?>
</body>
</html>
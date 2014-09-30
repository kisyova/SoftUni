<?php
function isPrime($num) {
    if($num == 1) {
        return false;
    }
    else if($num == 2) {
        return true;
    }
    else if($num % 2 == 0) {
        return false;
    }
    else {
        for($i = 3; $i <= ceil(sqrt($num)); $i += 2) {
            if($num % $i == 0) {
                return false;
            }
            return true;
        }
    }
}

?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<html>
<head>
    <title>Primes in range</title>
</head>
<body>
<form method="post">
    <label for="start">Start index: </label>
    <input name="start" type="text">
    <label for="end">End: </label>
    <input name="end" type="text">
    <input type="submit">
</form>
<?php
if(isset($_POST["start"]) && isset($_POST["end"])) {
    $start = $_POST["start"];
    $end = $_POST["end"];
    if($start < $end) {
        $result = array();
        for($num = $start; $num <= $end; $num++) {
            $result[] = isPrime($num) ? "<strong>$num</strong>" : $num;
        }
        echo implode(", ", $result);
    }
    else {
        echo "The strat number must be less tha the end number.";
    }
}
?>
</body>
</html>
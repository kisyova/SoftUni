<?php

function checkPalindrome($string) {
    $checkString = strtolower(preg_replace("/[^A-Za-z0-9]/", "", $string));
    return "$string " . ($checkString == strrev($checkString) ? " " : "not") . " a palindrome!";
}

function reverseString($string) {
    return strrev($string);
}

function splitString($string) {
    $result = array();
    preg_match_all('/[A-Za-zА-Яа-я]/', $string, $result);
    return implode(" ", $result[0]);
}

function hashString($string) {
    return crypt($string);
}

function shuffleString($string) {
    return str_shuffle($string);
}

?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<html>
<head>
    <title>Modify string</title>
</head>
<body>
<form method="post">
    <input name="string">
    <input type="radio" value="checkPalindrome" name="function" id="checkPalindrome">Check Palindrome
    <input type="radio" value="reverseString" name="function" id="reverseString">Reverse String
    <input type="radio" value="splitString" name="function" id=splitString"">Split String
    <input type="radio" value="hashString" name="function" id="hashString">Hash String
    <input type="radio" value="shuffleString" name="function" id="shuffleString">Shuffle String
    <input type="submit">
</form>
<?php
if(isset($_POST["string"]) && !empty($_POST["string"]) && isset($_POST["function"])) :
    $functions = ["checkPalindrome", "reverseString", "splitString", "hashString", "shuffleString"];
    if(in_array($_POST["function"], $functions)) {
        echo $_POST["function"]($_POST["string"]);
    }

?>
</body>
<?php endif; ?>
</html>
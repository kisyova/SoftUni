<?php
mb_internal_encoding('UTF-8');

if($_POST) {
    $firstName = trim($_POST["firstName"]);
    $lastName = trim($_POST["lastName"]);
    $email = trim($_POST["email"]);
    $phone = trim($_POST["phone"]);
    $birthDate = trim($_POST["birthDate"]);
    $nation = trim($_POST["nation"]);
    $company = trim($_POST["company"]);
    $from = trim($_POST["from"]);
    $to = trim($_POST["to"]);
    $languages = trim($_POST["languages"]);
    $langLevel = trim($_POST["langLevel"]);
    $forLanguage = trim($_POST["forLanguage"]);
    $comprLevel = trim($_POST["comprLevel"]);
    $readLevel = trim($_POST["readLevel"]);
    $writeLevel = trim($_POST["writeLevel"]);
    $category = array();

    if(!isset($_POST["sex"])) {
        $sex = "You must choose MALE or FEMALE!";
    }
    else {
        $sex = $_POST["sex"];
    }
    if(empty($birthDate)) {
        $birthDate = "Please select birth date!";
    }
    if(empty($from)) {
        $from = "Please select date!";
    }
    if(empty($to)) {
        $to = "Please select date!";
    }
    if(empty($_POST["category"])) {
        $category = [];
    }
    else {
        $category = $_POST["category"];
    }
    if(!(ctype_alpha($firstName)) || mb_strlen($firstName) <= 2 || mb_strlen($firstName) > 20) {
        $firstName = "The text must be between 2 and 20 symbols!";
    }
    if(!(ctype_alpha($lastName)) || mb_strlen($lastName) <= 2 || mb_strlen($lastName) > 20) {
        $lastName = "The text must be between 2 and 20 symbols!";
    }
    $forLanguage = array();
    $langLength = count($forLanguage);
    for($i = 0; $i < $langLength; $i++) {
    if(!(ctype_alpha($forLanguage[$i])) || mb_strlen($forLanguage[$i]) <= 2 || mb_strlen($forLanguage[$i]) > 20) {
        $forLanguage[$i] = "The text must be between 2 and 20 symbols!";
    }
}
    for ($i = 0; $i < $langLength; $i++) {
        if ($comprLevel[$i]==='-Comprehension-') {
            $comprLevel[$i]='Please select comprehension!';
        }
    }
    for ($i = 0; $i < $langLength; $i++) {
        if ($readLevel[$i]==='-Reading-') {
            $readLevel[$i] = 'Please select reading!';
        }
    }
    for ($i = 0; $i < $langLength; $i++) {
        if ($writeLevel[$i]==='-Writing-') {
            $writeLevel[$i] = 'Please select writing!';
        }
    }
    $languages = array();
    $pcLang = count($languages);
    for($i = 0; $i < $pcLang; $i++) {
        if(!(ctype_alpha($languages[$i])) || mb_strlen($languages[$i]) <= 2 || mb_strlen($languages[$i]) > 20) {
            $languages[$i] = "The text must be between 2 and 20 symbols!";
        }
    }
    if (!(ctype_alnum($company)) || mb_strlen($company) <= 2 || mb_strlen($company) > 20) {
        $company = "The text must be between 2 and 20 symbols!";
    }

    if (preg_match('/^[0-9 \' \'+-]+$/', $phone) !== 1) {
        $phone = "Please enter a valid phone number!";
    }

    if (filter_var($email, FILTER_VALIDATE_EMAIL) === false) {
        $email = "Please enter a valid email!";
    }
}
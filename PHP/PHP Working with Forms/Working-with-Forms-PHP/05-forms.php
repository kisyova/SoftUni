<?php
include("05-data.php");
?>

<!DOCTYPE html>
<html lang="en">
<meta charset="UTF-8">
    <html>
<title>CV Generator</title>
<head></head>
<body>
<form action="05-result.php" method="post">
    <fieldset id="personal">
        <legend>Personal Information</legend>
        <input type="text" name="firstName" placeholder="First Name"><br>
        <input type="text" name="lastName" placeholder="Last Name"><br>
        <input name="email" placeholder="Email" name="email"><br>
        <input name="phone" placeholder="Phone Number" name="phone"><br>
        <label for="female">Female</label>
        <input type="radio" id="female" name="sex" value="female">
        <label for="female">Male</label>
        <input type="radio" id="male" name="sex" value="male"><br>
        <label for="birthDate">Birth Date</label><br>
        <input type="date" id="birthDate" name="birthDate"><br>
        <label for="nation">Nationality</label><br>
        <select id="nation" name="nation">
            <option value="Bulgarian">Bulgarian</option>
            <option value="American">American</option>
            <option value="British">British</option>
            <option value="Korean">Korean</option>
            <option value="German">German</option>
        </select>
    </fieldset>
    <fieldset id="lastWork">
        <legend>Last Work Position</legend>
        <label for="company">Company Name</label>
        <input type="text" id="company" name="company"><br>
        <label for="from">From</label>
        <input type="date" id="from" name="from"><br>
        <label for="to">To</label>
        <input type="date" id="to" name="to">
    </fieldset>
    <fieldset id="computerSkills">
        <legend>Computer Skills</legend>
        <label for="languages">Programming Languages</label><br>
        <input type="text" id="languages" name="languages">
        <select name="langLevel">
            <option value="Beginner">Beginner</option>
            <option value="Average">Average</option>
            <option value="Advanced">Advanced</option>
            <option value="Ninja">Ninja</option>
        </select><br>
        <div id="newPCLangs"></div>
        <input type="button" name="removeLang" value="Remove Language" onclick="removeProgrammingLanguage("languages" + i)">
        <input type="button" name="addLang" value="Add Language" onclick="addProgrammingLanguage()">
    </fieldset>
    <fieldset id="otherSkills">
        <legend>Other Skills</legend>
        <label for="forLanguage">Language</label>
        <input type="text" name="forLanguage" id="forLanguage">
       <select name="comprLevel">
           <option value="0">-Comprehension-</option>
           <option value="beginner">beginner</option>
           <option value="intermediate">intermediate</option>
           <option value="advanced">advanced</option>
       </select>
        <select name="readLevel">
            <option value="0">-Reading-</option>
            <option value="beginner">beginner</option>
            <option value="intermediate">intermediate</option>
            <option value="advanced">advanced</option>
        </select>
        <select name="writeLevel">
            <option value="0">-Writing-</option>
            <option value="beginner">beginner</option>
            <option value="intermediate">intermediate</option>
            <option value="advanced">advanced</option>
        </select><br>
        <div id="otherLangs"></div>
        <input type="button" name="removeLang" value="Remove Language" onclick="removeLanguage("forLanguages" + j)">
        <input type="button" name="addLang" value="Add Language" onclick="addLanguage()"><br>
        <label for="category[]">Driving License</label><br>
        <label for="b">B</label>
        <input type="checkbox" id="b" name="category[]" value="B">
        <label for="a">A</label>
        <input type="checkbox" id="a" name="category[]" value="A">
        <label for="c">C</label>
        <input type="checkbox" id="c" name="category[]" value="C">
    </fieldset>
    <input type="submit" name="generator" value="Generate CV" onclick="submitAll()">
</form>
<script src="05-addRemoveButtons.js"></script>
</body>
    </html>
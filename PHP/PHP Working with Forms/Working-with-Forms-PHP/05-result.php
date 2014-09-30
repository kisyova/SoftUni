<?php
include("05-data.php");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Result</title>
    </head>
<body>
<a href="05-forms.php">FORM</a>
<table>
    <tbody>
    <tr>
        <th colspan="2">Personal Information</th>
    </tr>
    <tr>
        <td>First Name</td>
        <td><?= $firstName ?></td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td><?= $lastName ?></td>
    </tr>
    <tr>
        <td>Email</td>
        <td><?= $email ?></td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td><?= $phone ?></td>
    </tr>
    <tr>
        <td>Gender</td>
        <td><?= $sex ?></td>
    </tr>
    <tr>
        <td>Birth Date</td>
        <td><?= $birthDate ?></td>
    </tr>
    <tr>
        <td>Nationality</td>
        <td><?= $nation ?></td>
    </tr>
    </tbody>
</table>
<table>
    <tbody>
    <tr>
        <th colspan="2">Last Work Position</th>
    </tr>
    <tr>
        <td>Company Name</td>
        <td><?= $company ?></td>
    </tr>
    <tr>
        <td>From</td>
        <td><?= $from ?></td>
    </tr>
    <tr>
        <td>To</td>
        <td><?= $to ?></td>
    </tr>
    </tbody>
</table>
<table>
    <tbody>
    <tr>
        <td colspan="2">Computer Skills</td>
    </tr>
    <tr>
        <td>Programming Language</td>
        <td>
            <table>
                <tbody>
                <td>Language</td>
                <td>Skill Level</td>
                <?php
                $length = count($languages);
                for($i = 1; $i < $length; $i++) {
                    echo '<tr></tr>';
                    echo "<td>$languages[$i]</td>";
                    for($j = 1; $j < $length; $j++) {
                        echo "<td>$langLevel</td>";
                        break;
                    }
                }
                ?>
                </tbody>
            </table>
        </td>
    </tr>
    </tbody>
</table>
<table>
    <tbody>
    <tr>
        <td colspan="2">Other Skills</td>
    </tr>
    <tr>
        <td>Languages</td>
        <td>
            <table>
                <tbody>
                <td>Language</td>
                <td>Comprehension</td>
                <td>Reading</td>
                <td>Writing</td>
                <?php
                $length2 = count($forLanguage);
                for($i = 1; $i < $length2; $i++) {
                    echo "<tr></tr>";
                    echo "<td>$forLanguage[$i]</td>";
                    for($j = 1; $j < $length2; $j++) {
                        echo "<td>$comprLevel</td>";
                        for($k = 1; $k < $length2; $k++) {
                            echo "<td>$readLevel</td>";
                            for($h = 1; $h < $length2; $h++) {
                                echo "<td>$writeLevel</td>";
                            }
                            break;
                        }
                        break;
                    }
                    break;
                }
                ?>
                </tbody>
            </table>
        </td>
    </tr>
    <tr>
        <td>Driver's License</td>
        <td><?= implode(", ", $category); ?></td>
    </tr>
    </tbody>
</table>
</body>
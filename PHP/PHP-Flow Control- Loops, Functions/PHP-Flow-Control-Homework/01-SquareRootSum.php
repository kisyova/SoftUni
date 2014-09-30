<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <html>
<title>Square root sum</title>
<head>
<style>
    table {
        font-size: 20px;
    }
</style>
</head>
<body>
<table border="1">
    <thead>
    <tr>
        <td><strong>Number</strong></td>
        <td><strong>Square</strong></td>
    </tr>
    </thead>
    <tbody>
    <?php
    $sum = 0;
    for($i = 0; $i <= 100; $i += 2) {
        ?>
    <tr>
        <td><?php echo $i; ?></td>
        <td><?php echo round(sqrt($i), 2); ?></td>
    </tr>
    <?php
        $sum += sqrt($i);
    }
    ?>
    </tbody>
    <tfoot>
    <tr>
        <td><strong>Total:</strong></td>
        <td><?php echo round($sum, 2); ?></td>
    </tr>
    </tfoot>
</table>
</body>
    </html>

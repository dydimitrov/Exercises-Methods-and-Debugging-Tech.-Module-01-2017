<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;

        }
    </style>
</head>
<body>
<?php
$shades = 0;
for ($i = 1; $i <= 5; $i++) {
    for ($j = 1; $j <= 10; $j++) {
        echo "<div style='background-color: rgb($shades,$shades,$shades)'>";
        echo "</div>";
        $shades+=5;
    }
    $shades++;
    echo "</br>";
}

?>
</body>
</html>
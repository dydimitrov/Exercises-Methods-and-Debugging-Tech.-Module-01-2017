<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
$row = 9;
$col = 5;
for ($i = 1; $i <= $row; $i++) {
    for ($j = 1; $j <= $col; $j++) {
        if ($i==1 || $i==5){
            echo "<button style='background-color: blue;'>1</button>";
        }
        elseif ($i<=5 && $j==1){
            echo "<button style='background-color: blue;'>1</button>";
        }
        elseif ($i>5 && $j==$col){
            echo "<button style='background-color: blue;'>1</button>";
        }
        elseif ($i==$row){
            echo "<button style='background-color: blue;'>1</button>";
        }
        else{
            echo "<button>0</button>";
        }

    }
    echo "</br>";



}
?>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])){
    $num = intval($_GET['num']);
    $f0 = 1;
    $f1 = 1;
    $f2 = 2;
    echo "$f0 ";
    echo "$f1 ";
    echo "$f2 ";
    for ($i = 1; $i < $num-2; $i++){
        $fnext = $f0 + $f1 + $f2;
        $f0 = $f1;
        $f1 = $f2;
        $f2 = $fnext;
        echo "$f2 ";
    }

}
?>
</body>
</html>
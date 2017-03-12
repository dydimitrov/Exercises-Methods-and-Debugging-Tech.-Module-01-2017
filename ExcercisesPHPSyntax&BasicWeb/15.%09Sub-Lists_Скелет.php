<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num1" />
    M: <input type="text" name="num2" />
    <input type="submit" />
</form>
<ul>
    <?php
    if (isset($_GET['num1']) && isset($_GET['num2'])){
        $n1 = intval($_GET['num1']);
        $n2 = intval($_GET['num2']);
        for ($i = 1; $i <= $n1; $i++)
        {
            ?>
            <li><?php echo "List $i";?></br>

                <ul>
                    <?php
                    for ($j = 1; $j <= $n2; $j++) {?>
                        <li><?php echo "Element $i.$j";?></li>
                    <?php }?>

                </ul>
            </li>
        <?php } ?>
    <?php } ?>
</ul>
</body>
</html>
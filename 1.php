<?php
      $str = file_get_contents("INPUT.txt");
$k = 0;
$lenmax = 0;
$len = strlen($str);
$pos0 = 0;
$pos1 = 0;
while (true) {
        if($lenmax > $len - $k) {
        break;
    }
        $pos1 = strpos($str, '1', $k);
        $k = $pos1;
        $pos0 = strpos($str, '0', $k);
        if ($pos0 < $k) {
        $k = $len;
        $chain0 = $k;
    }
    else {
    $k = $pos0;
    }
    if ($pos0 > $pos1) {
    $lenmax = $pos0 - $pos1;    
    }
    else
    $lenmax = $pos1 - $pos0;
    echo $lenmax. " ";
}
echo $lenmax. " ";
$file = fopen("OUTPUT.txt", 'w');
fputs($file, $lenmax);
fclose($file);

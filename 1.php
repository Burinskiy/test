<?php
        //Enter your code here, enjoy!

      $str = file_get_contents("INPUT.txt");
$k = 0;
$lenmax = 0;
$len = strlen($str);
$chain0 = 0;
$chain1 = 0;
while (true) {
        if($lenmax >$k) {
        break;
    }
        $chain1 = strpos($str, '1', $k);
        $k = $chain1;
        $chain0 = strpos($str, '0', $k);
        if ($chain0 < 1) {
        $k = $len;
    }
    $k = $chain0;
    if ($chain0 > $chain1) {
    $lenmax = $chain0 - $chain1;    
    }
    else
    $lenmax = $chain1 - $chain0;
}
echo $lenmax. " ";
$file = fopen("OUTPUT.txt", 'w');
fputs($file, $lenmax);
fclose($file);

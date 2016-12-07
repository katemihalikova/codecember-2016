<?php

$input = "mily jezisku, prines mi prosim super pocitac.";

function encrypt(string $input, int $shift) {
  $ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  $abc = strtolower($ABC);
  $shift %= 26;
  return strtr($input, $ABC.$abc, substr($ABC, $shift).substr($ABC, 0, $shift).substr($abc, $shift).substr($abc, 0, $shift));
}

echo encrypt($input, 2); // okna lgbkumw, rtkpgu ok rtquko uwrgt rqekvce.

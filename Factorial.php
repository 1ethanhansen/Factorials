<?php 
// PHP code to get the factorial of a number 
// function to get factorial in iterative way 
function Factorial($number){ 
    $factorial = 1; 
    for ($i = 1; $i <= $number; $i++){ 
      $factorial = $factorial * $i; 
    } 
    return $factorial; 
} 
  
// Driver Code 
$number = 5; 
$fact = Factorial($number); 
echo "Factorial = $fact"; 
?> 

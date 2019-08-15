#!/bin/bash

echo "Enter the number to factorialize"
read factorial
counter=$factorial

echo "Factorial of $factorial is"

while (( counter > 1 ))
do
(( counter-- ))
(( factorial *= counter ))
done

echo $factorial

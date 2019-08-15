#!/usr/bin/perl

print "Enter the number to factorialize: ";
chomp ($factorial = <>);
$counter = $factorial;

print "$factorial! = ";

while($counter > 1){
	$counter--;
	$factorial *= $counter;
}

print "$factorial \n";

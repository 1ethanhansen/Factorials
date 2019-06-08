BEGIN {
	printf "Enter the number to factorialize ";
	getline num < "-";
	counter = num;
	total = 1;
	while (counter > 1) {
		total *= counter;
		counter--;
	}
	printf "%d! is %d \n", num, total;
}

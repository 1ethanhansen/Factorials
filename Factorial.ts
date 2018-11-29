var factorial = parseInt(prompt("Enter the number to factorialize"));
var counter = factorial;
var total = 1;

if (factorial > 0) {
	while (counter > 1) {
		total *= counter;
		counter--;
	}
	window.alert(factorial + "! = " + total);
} else {
	window.alert("That number is invalid");
}

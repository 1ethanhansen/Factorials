import os

number := os.input("Enter the number to factorialize: ").int()
mut counter := number
mut total := 1

if number > 0 {
	for counter > 1 {
		total *= counter
		counter = counter - 1
	}
	println("$number ! = $total")
} else {
	println("That is an invalid input.")
}

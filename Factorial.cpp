// Factorial.cpp : Defines the entry point for the console application.
// Ethan Hansen
// 2-14-2018
// takes in a nonnegative integer and returns its factorial

#include "stdafx.h"
#include <iostream>
using namespace std;

int main() {
	//Declaring variables
	int input;
	double total = 1;
	int counter;

	//PRS
	cout << "Enter a nonnegative integer to find the factorial ";
	cin >> input;

	counter = input;

	//Compute factorial if it is a valid integer & output result
	if (input > 0) {
		while (counter > 1) {
			total *= counter;
			counter--;
		} 
		cout << input << "! = " << total << endl;
	} else {
		cout << "That is invalid" << endl;
	}
}
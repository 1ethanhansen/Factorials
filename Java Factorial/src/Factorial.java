//Ethan Hansen
//2-16-2018
//Takes in an integer and returns the factorial of the integer

import java.util.Scanner;

public class Factorial {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scan = new Scanner(System.in);
		int factorial = scan.nextInt();
		int counter = factorial;
		int total = 1;
		
		if (factorial > 0) {
			while (counter > 1) {
				total *= counter;
				counter--;
			}
			System.out.println(factorial + "! = " + total);
		} else {
			System.out.println("That input is invalid");
		}
		
		scan.close();
	}

}

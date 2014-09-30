import java.util.Scanner;

public class SumTwoNumbers {

	public static void main(String[] args){
		
		Scanner in = new Scanner(System.in);
		System.out.println("Enter first number: ");
		int a = in.nextInt();
		System.out.println("Enter second number: ");
		int b = in.nextInt();
		
		int sum = a + b;
		
		System.out.println("The sum is: " + sum);
		
		in.close();
		
	}
}

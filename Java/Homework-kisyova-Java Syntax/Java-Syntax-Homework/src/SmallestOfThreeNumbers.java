import java.util.Locale;
import java.util.Scanner;


public class SmallestOfThreeNumbers {
	
	public static void main(String[] args){
		
		double a;
		double b;
		double c;
		double smallest;
		
		Locale.setDefault(Locale.US);
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("a = ");
		a = input.nextDouble();
		System.out.print("b = ");
		b = input.nextDouble();
		System.out.print("c = ");
		c = input.nextDouble();
		
		if((a < b) && (a < c)) {
			smallest = a;
			System.out.println("Smallest: " + smallest);
		}
		else if((b < a) && (b < c)) {
			smallest = b;
			System.out.println("Smallest: " + smallest);
		}
		else if((c < a) && (c < b)) {
			smallest = c;
			System.out.println("Smallest: " + smallest);
		}

}
}
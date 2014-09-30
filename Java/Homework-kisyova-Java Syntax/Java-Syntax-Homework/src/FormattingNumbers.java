import java.util.Locale;
import java.util.Scanner;


public class FormattingNumbers {

	public static void main(String[] args){
		
		Locale.setDefault(Locale.US);
		
		int a;
		float b, c;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("a = ");
		a = input.nextInt();
		System.out.print("b = ");
		b = input.nextFloat();
		System.out.print("c = ");
		c = input.nextFloat();
		
		if((a < 0) && (a > 500)) {
			System.out.println("Wrong input!");
		}
		else {
			
			String hex = Integer.toHexString(a);
			String byn = Integer.toBinaryString(a);
			
			System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", hex, byn, b, c);
		}
	}
}

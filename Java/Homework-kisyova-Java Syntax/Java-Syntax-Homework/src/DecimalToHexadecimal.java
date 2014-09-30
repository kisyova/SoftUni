import java.util.Scanner;


public class DecimalToHexadecimal {

	public static void main(String[] args) {
		
		int num;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Decimal: ");
		num = input.nextInt();
	
		String hex = Integer.toHexString(num);
		
		System.out.println("Hexadecimal: " + hex);
	}

}

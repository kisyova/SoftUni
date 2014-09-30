import java.util.Scanner;


public class CountOfBits {
	
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		int counter = 0;
		int integer;
		System.out.print("Integer = ");
		integer = input.nextInt();
		
		for(int i = 0; i < 32; i++) {
			if((integer & 1) == 1) {
				counter++;
			}
			integer = integer >> 1;
		}
		
		System.out.println("Ones: " + counter);
	}

}

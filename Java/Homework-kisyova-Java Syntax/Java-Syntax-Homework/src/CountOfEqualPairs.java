import java.util.Scanner;


public class CountOfEqualPairs {
	
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		 System.out.print("Enter an integer number:");
         String value = Integer.toBinaryString(input.nextInt());
         
         int counter = 0;
         
         for (int i = 0; i < value.length() - 1; i++) {
                 if (value.charAt(i) == value.charAt(i + 1))
                         counter++;
         }
         System.out.println("Pairs: " + counter);
		
	}

}

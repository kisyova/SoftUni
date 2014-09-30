import java.util.Scanner;


public class Ex01_SymmetricNumbersInRange {
	
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Input two numbers between 0 and 999: ");
		int start = input.nextInt();
		int end = input.nextInt();
		
		if(end < start) {
			System.out.println("Wrong input!");
		}
		
		if(start < 0 && end > 999) {
			System.out.println("Wrong input!");
		}
		
		for(int i = start; i <= end; i++){
		
			if(i < 10){
				System.out.print(i + " ");
			}
			else if(i >= 10 && i <= 99) {
				int div = i / 10;
				int ost = i % 10;
				if(div == ost) {
					System.out.print(i + " ");
				}
			}
			else if(i >= 100 && i <= 999) {
				int div = i / 100;
				int ost1 = i % 100;
				int ost2 = ost1 % 10;
				if(div == ost2) {
					System.out.print(i + " ");
				}
			}
		}
		
		System.out.println();
	}

}

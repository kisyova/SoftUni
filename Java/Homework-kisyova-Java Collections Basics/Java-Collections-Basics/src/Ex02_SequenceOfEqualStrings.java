import java.util.Scanner;


public class Ex02_SequenceOfEqualStrings {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Input your strings: ");
		String str = input.nextLine();
		String[] array = str.split(" ");
		
		System.out.print(array[0]);
		for(int i = 1; i < array.length; i++) {
			if(array[i].equals(array[i - 1])) {
				System.out.print(" " + array[i]);
			}
			else {
				System.out.println();
				System.out.print(array[i]);
			}
		}
		

	}

}

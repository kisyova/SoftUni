import java.util.Arrays;
import java.util.Scanner;


public class Ex01_SortArrayOfNumbers {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
	
		Scanner input = new Scanner(System.in);
		System.out.print("Numbers: ");
		int n = input.nextInt();
		int[] numbers = new int[n];
		
		for(int i = 0; i < n; i++) {
			numbers[i] = input.nextInt();
		}
		for(int j = 0; j < numbers.length - 1; j++) {
			for(int k = j + 1; k < numbers.length; k++) {
				if(numbers[j] > numbers[k]) {
					int tempNums = numbers[j];
					numbers[j] = numbers[k];
					numbers[k] = tempNums;
				}
			}
		}

			System.out.print(Arrays.toString(numbers));
	
}
}

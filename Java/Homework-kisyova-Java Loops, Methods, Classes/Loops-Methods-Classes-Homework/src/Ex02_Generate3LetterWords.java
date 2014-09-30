import java.util.Scanner;


public class Ex02_Generate3LetterWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		System.out.print("Input one to three letter/s: ");
		char[] letters = input.next().toCharArray();
		
		if(letters.length == 3) {
			for(int i = 0; i < 3; i++) {
				for(int j = 0; j < 3; j++) {
					for(int h = 0; h < 3; h++) {
						System.out.printf("%s%s%s ", letters[i],letters[j], letters[h]);
					}
				}
			}
		}
		else if(letters.length == 2) {
			for(int i = 0; i < 2; i++) {
				for(int j = 0; j < 2; j++) {
					for(int h = 0; h < 2; h++) {
						System.out.printf("%s%s%s ", letters[i],letters[j], letters[h]);
					}
				}
			}
		}
		
		else if(letters.length == 1) {
			System.out.printf("%s%s%s",letters[0],letters[0],letters[0]);
		}

	}

}

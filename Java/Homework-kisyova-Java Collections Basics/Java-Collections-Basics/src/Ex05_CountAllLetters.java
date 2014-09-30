import java.util.Scanner;


public class Ex05_CountAllLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		String text = input.nextLine();
		String[] countOfWords = text.split("([().,!?:;'\"-]|\\s)+");
		
		System.out.println();
		System.out.print(countOfWords.length);

	}

}

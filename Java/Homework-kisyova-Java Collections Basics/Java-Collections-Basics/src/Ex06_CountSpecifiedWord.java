import java.util.Scanner;


public class Ex06_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		String text = input.nextLine();
		String specifiedWord = input.next();
		String[] words = text.split("([().,!?:;'\"-]|\\s)+");
		
		int counter = 0;
		for (String currentWord : words) {
		    if (currentWord.equalsIgnoreCase(specifiedWord)) {
			counter++;
		    }
		}
		System.out.println(counter);

	}

}

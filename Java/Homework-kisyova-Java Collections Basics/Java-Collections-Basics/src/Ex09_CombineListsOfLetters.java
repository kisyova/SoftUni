import java.util.ArrayList;
import java.util.Scanner;


public class Ex09_CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		ArrayList<Character> l1 = new ArrayList<>();
		ArrayList<Character> l2 = new ArrayList<>();
		for (char character : input.nextLine().toCharArray()) {
		    l1.add(character);
		}
		for (char character : input.nextLine().toCharArray()) {
		    l2.add(character);
		}
		
		ArrayList<Character> output = new ArrayList<>();
		output.addAll(l1);
		for (int i = 0; i < l2.size(); i++) {
		    if (!l1.contains(l2.get(i))) {
			output.add(' ');
			output.add(l2.get(i));
		    }
		}
		for (char character : output) {
		    System.out.print(character);
		}

	}

}

import java.util.Scanner;


public class Ex07_CountSustringOccurences {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		String text = input.nextLine().toLowerCase();
		String subString = input.next().toLowerCase();
		int counter = countSubstring(text, subString);
		System.out.println(counter);
	    }

	    public static int countSubstring(final String string, final String substring) {
		int count = 0;
		int i = 0;

		while ((i = string.indexOf(substring, i)) != -1) {
		    i++;
		    count++;
		}

		return count;

	}
}


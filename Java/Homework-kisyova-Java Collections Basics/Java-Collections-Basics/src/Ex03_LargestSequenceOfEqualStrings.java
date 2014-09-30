import java.util.Scanner;


public class Ex03_LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		String[] array = str.split(" ");
		
	  int counter = 1;
	  int maxCounter = 1;
	  String word = array[0] + "";
	  for(int i = 0; i < array.length - 1; i++) {
		  if(array[i].equals(array[i + 1])) {
			  counter++;
			  if(i == array.length - 2) {
				  if(maxCounter < counter) {
					  word = array[i] + "";
					  maxCounter = counter;
				  }
			  }
		  }
		  else {
			  if(maxCounter < counter) {
				  word = array[i] + "";
				  maxCounter = counter;
			  }
			  counter = 1;
		  }
	  }
	  for(int i = 0; i < maxCounter; i++) {
		  System.out.print(word + " ");
	  }
	}

}

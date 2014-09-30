import java.util.Scanner;
import java.util.TreeSet;


public class Ex10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		
		 Scanner input = new Scanner(System.in); 
          
	     String[] words =  input.nextLine().split("\\W+");
         TreeSet<String> orderedWords = new TreeSet<>();
            
         for (int i = 0; i < words.length; i++) {
                    orderedWords.add(words[i].toLowerCase());
            }
           
            for (String word : orderedWords) {
                    System.out.print(word + " ");
            }

	}

}

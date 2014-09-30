import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class Ex11_MostFrequentWord {

	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
            
		String[] words =  input.nextLine().split("\\W+");
        TreeMap<String, Integer> wordOccurrences = new TreeMap<>();
           
        int maxCount = 0;
        for (String word : words) {
             word = word.toLowerCase();
             Integer wordCount = wordOccurrences.get(word);
             if (wordCount == null) {
                    wordCount = 0;
                }
             if (wordCount + 1 > maxCount) maxCount = wordCount + 1;
                 wordOccurrences.put(word, wordCount + 1);
            }
           
            for (Map.Entry<String, Integer> entry : wordOccurrences.entrySet()) {
                    if (entry.getValue() == maxCount) {
                            System.out.println(entry.getKey() + " -> "
                                            + maxCount + " times");
                    }
            }

	}

}

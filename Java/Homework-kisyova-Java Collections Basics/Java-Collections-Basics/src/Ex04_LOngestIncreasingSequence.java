import java.util.Scanner;


public class Ex04_LOngestIncreasingSequence {

	public static void main(String[] args) {
	    Scanner input = new Scanner(System.in);
	    String str = input.nextLine();
	    String[] strNumbers = str.split(" ");
	    int[] numbers = new int[strNumbers.length + 1];
	    
	    for(int i = 0; i < strNumbers.length; i++) {
	    	numbers[i] = Integer.parseInt(strNumbers[i]);
	    }
	    
	    numbers[numbers.length - 1] = Integer.MIN_VALUE;
	    
	    int longest = 1;
	    int current = 1;
	    for(int i = 0; i < numbers.length - 1; i++) {
	    	if(numbers[i] < numbers[i + 1]) {
	    		current++;
	    		System.out.print(numbers[i] + " ");
	    	}
	    	else {
	    		System.out.println(numbers[i]);
	    		if(longest > current) {
	    			longest = current;
	    		}
	    		current = 1;
	    	}
	    }
	    
	    for(int i = 0; i < numbers.length - 1; i++) {
	    	if(numbers[i] < numbers[i + 1]) {
	    		current++;
	    	}
	    	else {
	    		if(longest == current) {
	    			System.out.print("Longest: ");
	    			for(int j = i - longest + 1; j <= i; j++) {
	    				System.out.print(numbers[j] + " ");
	    			}
	    			break;
	    		}
	    		current = 1;
	    	}
	    }

	}

}

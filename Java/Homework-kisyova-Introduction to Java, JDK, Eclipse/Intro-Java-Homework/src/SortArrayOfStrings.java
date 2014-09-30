import java.util.Scanner;
import java.util.Arrays;


public class SortArrayOfStrings {
	
	public static void main(String[] args){
		Scanner input = new Scanner(System.in);
		
		System.out.println("Enter a number: ");
		int num = input.nextInt();
		String[] cities = new String[num];
		for(int i = 0; i < num; i++)
		{
			cities[i] = input.next();
		}
		
		Arrays.sort(cities);
		
		for(int j = 0; j < num; j++){
		
			System.out.println(cities[j]);
		}
		
		input.close();
	}

}

import java.util.Scanner;


public class RectangleArea {
	public static void main(String[] args){
		Scanner input = new Scanner(System.in);
		
		int a,b;
		System.out.print("a = ");
		a = input.nextInt();
		System.out.print("b = ");
		b = input.nextInt();
		
		if((a <= 0) || (b <= 0)){
			System.out.println("Wrong input");
		}
		else {
		int area = a * b;
		
		System.out.println("Area = " + area);
		}
		
	}

}

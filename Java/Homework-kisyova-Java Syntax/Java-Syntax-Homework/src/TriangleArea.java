import java.util.Scanner;


public class TriangleArea {

	public static void main(String[] args){
		
		int ax, ay;
		int bx, by;
		int cx, cy;
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("A coordinates: ");
		ax = input.nextInt();
		ay = input.nextInt();
		
		System.out.print("B coordinates: ");
		bx = input.nextInt();
		by = input.nextInt();
		
		System.out.print("C coordinates: ");
		cx = input.nextInt();
		cy = input.nextInt();
		
		int area = ((ax * (by - cy) + bx * (cy - ay) + cx * (ay - by))) / 2;
		
		if(area < 0){
			area = area * (-1);
			System.out.println("Area: " + area);
		}
		else {
			System.out.println("Area: " + area);
		}
	}
}

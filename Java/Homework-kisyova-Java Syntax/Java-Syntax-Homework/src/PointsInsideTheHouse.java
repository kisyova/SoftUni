import java.util.Locale;
import java.util.Scanner;


public class PointsInsideTheHouse {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		Locale.setDefault(Locale.US);
		
		System.out.print("Enter coordinates: ");
		double pointX = input.nextDouble();
		double pointY = input.nextDouble();
		
		double x1 = 12.5;
		double y1 = 8.5;
		double x2 = 22.5;
		double y2 = 8.5;
		double x3 = 17.5;
		double y3 = 3.5;
		
		double ABC = Math.abs (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
		double ABP = Math.abs (x1 * (y2 - pointY) + x2 * (pointY - y1) + pointX * (y1 - y2));
		double APC = Math.abs (x1 * (pointY - y3) + pointX * (y3 - y1) + x3 * (y1 - pointY));
		double PBC = Math.abs (pointX * (y2 - y3) + x2 * (y3 - pointY) + x3 * (pointY - y2));
		
		boolean isInTriangle = ABP + APC + PBC == ABC;
		
		if(isInTriangle) {
			System.out.println("Inside");
		}
		else if(((pointX >= 12.5) && (pointX <= 17.5)) && ((pointY >= 8.5) && (pointY <= 13.5))) {
			System.out.println("Inside");
		}
		else if(((pointX >= 20) && (pointX <= 22.5)) && ((pointY >= 8.5) && (pointY <= 13.5))) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Otside");
		}
		
	}
}

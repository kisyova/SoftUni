import java.util.Locale;
import java.util.Scanner;


public class PointsInsideFigure {
	
	public static void main(String[] args){
		
		double pointX;
		double pointY;
		
		Locale.setDefault(Locale.US);
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Input X and Y coordinates: ");
		pointX = input.nextDouble();
		pointY = input.nextDouble();
		
		if(((pointX >= 12.5) && (pointX <= 22.5)) && ((pointY >= 6) && (pointY <= 8.5))){
			System.out.println("Inside");
		}
		else if(((pointX >= 12.5) && (pointX <= 17.5)) && ((pointY >= 8.5) && (pointY <= 13.5))) {
			System.out.println("Inside");
		}
		else if(((pointX >= 20) && (pointX <= 22.5)) && ((pointY >= 8.5) && (pointY <= 13.5))) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
	}

}

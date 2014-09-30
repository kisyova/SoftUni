using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write("First side: ");
        double smallBase = double.Parse(Console.ReadLine());
        Console.Write("Second side: ");
        double bigBase = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        if ((smallBase <= 0) || (bigBase <= 0) || (height <= 0))
        {
            Console.WriteLine("Invalid input!!!");
        }
        else
        {
            if (smallBase >= bigBase)
            {
                Console.WriteLine("Invalid input!!!");
            }
            else
            {
                double area = ((smallBase + bigBase) / 2) * height;

                Console.WriteLine("The area of the trapezoid is: {0}", area);
            }

        }
    }
}


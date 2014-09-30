using System;

    class CirclePerimeterArea
    {
        static void Main()
        {
            Console.Write("Enter a value for the radius og the circle: ");
            double radius = double.Parse(Console.ReadLine());
            float pi = 3.14f;

            double circlePerimeter = 2 * pi * radius;
            double circleArea = pi * Math.Pow(radius,2);

            Console.WriteLine("Perimeter = {0:0.00}",circlePerimeter);
            Console.WriteLine("Area = {0:0.00}",circleArea);
        }
    }


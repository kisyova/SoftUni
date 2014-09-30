using System;

    class Rectangle
    {
        static void Main()
        {
            Console.WriteLine("Input width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Input height: ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * height;
            double area = width * height;

            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }


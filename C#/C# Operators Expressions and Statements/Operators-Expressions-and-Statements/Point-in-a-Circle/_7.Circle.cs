using System;

    class Circle
    {
        static void Main()
        {
            int xCenter = 0;
            int yCenter = 0;
            int radius = 2;

            Console.WriteLine("Input the coordinates of a point: ");
            double xPoint = double.Parse(Console.ReadLine());
            double yPoint = double.Parse(Console.ReadLine());

            if (xPoint * xPoint + yPoint * yPoint <= radius * radius)
            {
                bool point = true;
                Console.WriteLine(point);
            }
            else
            {
                bool point = false;
                Console.WriteLine(point);
            }

        }
    }


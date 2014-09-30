using System;

    class PointsCircleRectangle
    {
        static void Main()
        {
            int xCenter = 1;
            int yCenter = 1;
            float radius = 1.5f;

            Console.Write("Input x coordinate: ");
            double xPoint = double.Parse(Console.ReadLine());

            Console.Write("Input y coordinate: ");
            double yPoint = double.Parse(Console.ReadLine());
            Console.WriteLine();

            bool result = (((xPoint - xCenter) * (xPoint - yCenter) + (yPoint - xCenter) * (yPoint - yCenter)) <= 2.25)
                && ((xPoint <= 5) || ((xPoint >= -1) && ((yPoint <= -1) || (yPoint >= 1)))); //radius*radius=2.25
            Console.WriteLine("Is the point in the circle and out og the rectangle?: {0}", result);

            }
        }
    


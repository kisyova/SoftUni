using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());

            double greaterNumber = Math.Max(a, b);
            double lowerNumber = Math.Min(a, b);

            Console.WriteLine("Greater: {0}",greaterNumber);
            Console.WriteLine("Lower: {0}",lowerNumber);
        }
    }


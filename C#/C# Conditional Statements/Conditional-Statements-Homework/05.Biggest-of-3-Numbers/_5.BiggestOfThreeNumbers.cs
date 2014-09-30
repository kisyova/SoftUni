using System;

    class TheBiggestOfThreeNumbers
    {

    
        static void Main()
        {
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double third = double.Parse(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("The biggest: {0}",first);
            }
            else if (second > first && second > third)
                {
                    Console.WriteLine("The biggest: {0}", second);
                }
            else if (third > first && third > second)
                {
                    Console.WriteLine("The biggest: {0}", third);
                }
            else
            {
                Console.WriteLine("The numbers cannot be equal!");
            }

    }
   
    }


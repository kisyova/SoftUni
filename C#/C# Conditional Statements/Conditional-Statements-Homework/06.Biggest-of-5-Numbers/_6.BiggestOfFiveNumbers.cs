using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("ENTER FIVE DIFFERENT NMBERS!!!");

            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double third = double.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            double fourth = double.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            double fifth = double.Parse(Console.ReadLine());

            if (first > second && first > third && first > fourth && first > fifth)
            {
                Console.WriteLine("The biggest: {0}",first);
            }
            else if (second > first && second > third && second > fourth && second > fifth)
            {
                Console.WriteLine("The biggest: {0}", second);
            }
            else if (third > first && third > second && third > fourth && third > fifth)
            {
                Console.WriteLine("The biggest: {0}", third);
            }
            else if (fourth > first && fourth > second && fourth > third && fourth > fifth)
            {
                Console.WriteLine("The biggest: {0}", fourth);
            }
            else if (fifth > first && fifth > second && fifth > third && fifth > fourth)
            {
                Console.WriteLine("The biggest: {0}", fifth);
            }
            else
            {
                Console.WriteLine("The numbers cannot be equal!!!");
            }


        }
    }


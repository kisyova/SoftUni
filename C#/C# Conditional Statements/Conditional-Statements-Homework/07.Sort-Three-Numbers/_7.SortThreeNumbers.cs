using System;

    class SortThreeNumbers
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
                if (second >= third)
                {
                    Console.WriteLine(first + " " + second + " " + third);
                }
                else
                {
                    Console.WriteLine(first + " " + third + " " + second);
                }
            }
            else
            {
                if (second > first && second > third)
                {
                    if (first >= third) 
                    {
                        Console.WriteLine(second + " " + first + " " + third);
                    }
                    else
                    {
                        Console.WriteLine(second + " " + third + " " + first);
                    }
                }
                if (third > first && third > second)
                {
                    if (first >= second)
                    {
                        Console.WriteLine(third + " " + first + " " + second);
                    }
                    else
                    {
                        Console.WriteLine(third + " " + second + " " + first);
                    }
                }
            }
        }
    }


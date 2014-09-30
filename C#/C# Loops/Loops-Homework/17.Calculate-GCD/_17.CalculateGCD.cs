using System;

    class CalcilateGCD
    {
        static void Main()
        {
            Console.Write("Enter your first integer number: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Enter your second integer number: ");
            double second = double.Parse(Console.ReadLine());

            do
            {
                first = Math.Abs(first - second);

                if (first != second)
                {
                    second = Math.Abs(second - first);
                }
            } while (second != first);

            Console.WriteLine(first);

        }
    }


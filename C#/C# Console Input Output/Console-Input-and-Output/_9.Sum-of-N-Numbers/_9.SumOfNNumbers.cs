using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            int counter;
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());
            double otherNumber;
            double sumOfNumbers = 0;

            for(counter = 0; counter < number; counter++)
            {
                Console.Write("Enter a number: ");
                otherNumber = double.Parse(Console.ReadLine());
                sumOfNumbers += otherNumber;
                Console.WriteLine("The sum of all numbers is {0}.",sumOfNumbers);
            }
        }
    }


using System;

    class SumOfIntegers
    {
        static void Main()
        {
            Console.Write("First integer: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Second integer: ");
            int secondInt = int.Parse(Console.ReadLine());
            Console.Write("Third integer: ");
            int thirdInt = int.Parse(Console.ReadLine());

            int sum = firstInt + secondInt + thirdInt;

            Console.WriteLine("The sum of the three integers is: {0}",sum);
        }
    }


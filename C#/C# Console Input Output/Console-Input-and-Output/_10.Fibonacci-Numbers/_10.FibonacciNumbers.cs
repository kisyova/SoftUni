using System;
using System.Numerics;

class PFibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            BigInteger firstFibonacci = 0;
            BigInteger secondFibonacci = 1;
            BigInteger nextFibonacci;
            Console.WriteLine(firstFibonacci);
            Console.WriteLine(secondFibonacci);

            for (int i = 1; i < n - 1; i++)
            {
                nextFibonacci = firstFibonacci + secondFibonacci;
                firstFibonacci = secondFibonacci;
                secondFibonacci = nextFibonacci;
                Console.WriteLine(nextFibonacci);
            }
        }
    }
}

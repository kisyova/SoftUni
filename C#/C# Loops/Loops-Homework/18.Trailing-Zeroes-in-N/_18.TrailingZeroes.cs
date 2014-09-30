using System;
using System.Numerics;

    class TrailingZeroes
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            int trailingZeroes = 0;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            while (factorialN % 10 == 0)
            {
                trailingZeroes++;
                factorialN /= 10;
            }

            Console.WriteLine("The number of trailing zeroes is/are: " + trailingZeroes);
        }

    }


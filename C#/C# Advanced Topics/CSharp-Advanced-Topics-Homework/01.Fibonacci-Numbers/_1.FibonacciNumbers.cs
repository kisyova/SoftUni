using System;
using System.Numerics;

    class FibonacciNumbers
    {

        static void Main()
        {
            Console.Write("Enter a positive integer number: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger result = Fib(n);

            Console.WriteLine(result);

        }
       
        private static BigInteger Fib(int n)
        {
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger next = 0;

            if (n == 0)
            {
                Console.WriteLine(first);
            }

            else if(n == 1)
            {
                Console.WriteLine(second);
            }

            else
            {

            for (int i = 1; i <= n; i++)
            {
                next = first + second;
                first = second;
                second = next;

                if (i == n)
                {
                    return next;
                }
            }
        }

            return 0;

    }

    }
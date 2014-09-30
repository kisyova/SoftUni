using System;

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter a value for N: ");
            int n = int.Parse(Console.ReadLine());

            int doubleN = 2 * n;
            double factorial2N = 1;
            double factorialN = 1;
            double factorialN1 = n + 1;
            double result = 0;

            if (n > 1 && n < 100)
            {
                for (int i = 1; i <= doubleN; i++)
                {
                    factorial2N *= i;

                    if (i <= n)
                    {
                        factorialN *= i;
                    }
                }
                for (int i = 1; i < n + 1; i++)
                {
                    factorialN1 *= i;
                }

                result = factorial2N / (factorialN * factorialN1);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
    }


using System;

    class Combinations
    {
        static void Main()
        {
            Console.Write("Enter a value for N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for K: ");
            int k = int.Parse(Console.ReadLine());
            
            double factorialN = 1;
            double factorialK = 1;
            double  factorialNK = 1;
            double result = 0;
            double nk = n - k;

            if (k > 1 && n > k && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *=i;

                    if (i <= k)
                    {
                        factorialK *= i;
                    }

                }

                for (int i = 1; i <= nk; i++)
                {
                    factorialNK *= i;
                }

                    result = factorialN / (factorialK * factorialNK);
                    Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
            
        }
    }


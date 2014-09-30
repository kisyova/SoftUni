using System;

    class CalculateNK
    {
        static void Main()
        {
            Console.Write("Enter a value for N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for K: ");
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            double result;
           
            if(k > 1 && n > k && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;

                    if (i <= k)
                    {
                        factorialK *= i;
                    }
                }
                
                result = factorialN / factorialK;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wronf input!!!");
            }
        }
    }


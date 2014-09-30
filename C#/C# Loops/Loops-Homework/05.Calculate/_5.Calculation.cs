using System;

    class Calculation
    {
        static void Main()
        {
            Console.Write("Enter a positove integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a positove integer number: ");
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            int factorialN = 1;

            for (int i = 1; i < n; i++)
            {
                factorialN *= i;
                sum += (factorialN / Math.Pow(i,n));
               
            }

                Console.WriteLine("{0:F5}", sum);
        }
    }


using System;


    class PrimeChecker
    {
        public static void Main()
        {
            Console.Write("Enter a positive integer number: ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Is number {0} prime ? {1} !", n, PrimeChecker.IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) 
                    return false;
                }
            }

            return true;
        }

       
    }
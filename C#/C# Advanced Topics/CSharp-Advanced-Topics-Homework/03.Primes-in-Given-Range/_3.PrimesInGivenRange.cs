using System;
using System.Linq;
using System.Collections.Generic;

    class PrimesInGivenRange
    {
        static void Main()
        {
            Console.Write("Enter a start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter an end number ");
            int end = int.Parse(Console.ReadLine());

            List<int> range = PrimesInGivenRange.FindPrimesInRange(start,end);

            Console.WriteLine("The prime numbers in the interval between {0} and {1} is/are:",start,end);
            range.ForEach(Console.WriteLine);
        }

        static List<int> FindPrimesInRange(int startNumber,int endNUmber)
        {
            List<int> primeNumbers = new List<int> { };
            int length = 0;

            if (startNumber > endNUmber) 
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = startNumber; i < endNUmber; i++)
                {
                    if (PrimesInGivenRange.IsPrime(i))
                    {
                        primeNumbers.Add(i);
                        length++;
                    }
                }
            }

            return primeNumbers;
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


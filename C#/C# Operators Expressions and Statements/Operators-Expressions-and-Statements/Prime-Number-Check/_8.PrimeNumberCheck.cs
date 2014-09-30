using System;

class PrimeNumberCheck
{
    static void Main()
    {
        byte number = byte.Parse(Console.ReadLine());

        if (number > 101)
        {
            Console.WriteLine("The number cannot be higher than 100!");
        }
        else
        {
            if ((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 7 == 0))
            {
                bool primeNumber = true;
                Console.WriteLine(primeNumber);
            }
            else
            {
                bool primeNumber = false;
                Console.WriteLine(primeNumber);
            }
        }

    }

}
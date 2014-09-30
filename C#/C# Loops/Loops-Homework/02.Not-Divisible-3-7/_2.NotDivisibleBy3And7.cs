using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            else
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();

    }
}


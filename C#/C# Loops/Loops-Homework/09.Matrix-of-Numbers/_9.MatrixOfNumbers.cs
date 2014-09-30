using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a value for N: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n; col++) 
                {
                    Console.Write(row + col + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong input!!!");
        }
    }
}

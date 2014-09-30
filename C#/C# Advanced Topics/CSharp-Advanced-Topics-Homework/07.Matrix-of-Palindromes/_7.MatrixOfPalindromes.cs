using System;

    class MatrixOfPalindromes
    {
        static void Main()
        {
            Console.Write("Enter a value for the rows: ");
            int row=int.Parse(Console.ReadLine());
            Console.Write("Enter a value for the columns: ");
            int column=int.Parse(Console.ReadLine());

            string[,] matrix = new string[row,column];

            char symbol1 = 'a';
            for (int i = 0; i < row; i++)
            {
                char symbol2 = symbol1;
                for (int j = 0; j < column; j++)
                {
                    string word = symbol1.ToString() + symbol2.ToString() + symbol1.ToString();
                    matrix[i, j] = word;
                    symbol2++;
                }

                symbol1++;
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(" " + matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }


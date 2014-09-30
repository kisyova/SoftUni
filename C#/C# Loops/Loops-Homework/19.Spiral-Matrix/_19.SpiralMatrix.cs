using System;

    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("Enter a positive integer between 1 and 20 :");
            short n = short.Parse(Console.ReadLine());
            Console.Clear();

            int[,] spiralMatrix = new int[n, n];
            int row = 0;
            int column = 0;
            int min = 1;

            if (n < 1 && n > 20)
            {
                Console.WriteLine("The input is incorrect!");
            }
            else
            {
                while (min <= n * n)
                {
                    while (column < spiralMatrix.GetLength(0) && spiralMatrix[row,column] == 0)
                    {
                        spiralMatrix[row, column++] = min;
                        min++;
                    }

                    column--;
                    row++;

                    while (row < spiralMatrix.GetLength(1) && spiralMatrix[row, column] == 0)
                    {
                        spiralMatrix[row++, column] = min;
                        min++;
                    }

                    row--;
                    column--;

                    while (column >= 0 && spiralMatrix[row, column] == 0)
                    {
                        spiralMatrix[row, column--] = min;
                        min++;
                    }

                    column++;
                    row--;

                    while (row >= 0 && spiralMatrix[row, column] == 0)
                    {
                        spiralMatrix[row--, column] = min;
                        min++;
                    }

                    column++;
                    row++;
                }

                for (int index1 = 0; index1 < spiralMatrix.GetLength(0); index1++)
                {
                    for (int index2 = 0; index2 < spiralMatrix.GetLength(1); index2++)
                    {
                        Console.SetCursorPosition(index2 * 5, index1 * 2);
                        Console.Write(spiralMatrix[index1,index2]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }


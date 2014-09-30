using System;
using System.Collections.Generic;

class MinMaxSumAverageNumbers
{
    static void Main()
    {
        checked
        {
            Console.Write("Enter how many numbers: ");
            string n = Console.ReadLine();
            int count = int.Parse(n);
            if (count < 1)
            {
                Console.WriteLine("Numbers must be more than 1!");
            }
            else
            {
                List<int> numbers = new List<int>(count);
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter a number: ");
                    n = Console.ReadLine();
                    numbers.Add(int.Parse(n));
                }

                int min = int.MaxValue;
                int max = int.MinValue;
                double sum = 0;
                
                foreach (var number in numbers)
                {
                    min = Math.Min(min, number);
                    max = Math.Max(max, number);
                    sum += number;
                }
                
                double average = sum / count;
                
                Console.WriteLine("Minimum: " + min);
                Console.WriteLine("Maximum: " + max);
                Console.WriteLine("Sum of all numbers: " + sum);
                Console.WriteLine("Average number: {0:F2}",average);
            }
            
        }
    }
}


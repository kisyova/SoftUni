using System;
using System.Linq;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first integers: ");
            string firstNumbers = Console.ReadLine();
            Console.WriteLine("Enter the second integers: ");
            string secondNumbers = Console.ReadLine();
            string[] firstLine = firstNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondLine = secondNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            List<int> firstList = new List<int> { };
            List<int> secondList = new List<int> { };

            for (int i = 0; i < firstLine.Length; i++)
            {
                secondList.Add(int.Parse(firstLine[i]));
            }

            for (int i = 0; i < secondLine.Length; i++)
            {
                secondList.Add(int.Parse(secondLine[i]));
            }

            secondList.Sort();
            firstList = secondList.Distinct().ToList();

            foreach (var numbers in firstList)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();
        }
    }


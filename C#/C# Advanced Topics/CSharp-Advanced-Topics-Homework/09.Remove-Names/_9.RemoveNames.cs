using System;
using System.Linq;
using System.Collections.Generic;

    class RemoveNames
    {
        static void Main()
        {
            Console.WriteLine("Enter the first names: ");
            string firstInput = Console.ReadLine();
            string[] firstNames = firstInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Enter the secon names: ");
            string secondInput = Console.ReadLine();
            string[] secondNames = secondInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> firstList = firstNames.ToList<string>();
            List<string> secondList = secondNames.ToList<string>();

            for (int i = 0; i < secondList.Count; i++)
            {
                for (int j = 0; j < firstList.Count; j++)
                {
                    if (firstList.Contains(secondList[i]))
                    {
                        firstList.Remove(secondList[i]);
                    }
                }
            }

            Console.WriteLine("Names after removing is done: ");

            foreach (var item in firstList)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
        }
    }

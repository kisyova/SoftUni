using System;
using System.Linq;
using System.Collections.Generic;


    class LongestAreaInArray
    {
        static void Main()
        {
            Console.Write("Enter how many inputs there will be: ");
            int nInt = int.Parse(Console.ReadLine());

            Dictionary<string, int> nString = new Dictionary<string, int> { };
            Console.WriteLine("Enter {0} strings: ",nInt);

            for (int i = 0; i < nInt; i++)
            {
                Console.Write("{0}. ",i+1);
                string word = Console.ReadLine();

                if (!nString.ContainsKey(word))
                {
                    nString.Add(word, 1);
                }
                else
                {
                    nString[word]++;
                }
            }

            int count = nString.Values.Max();

            List<string> countFrom = new List<string> { };

            foreach (var word in nString.Keys)
            {
                if (!countFrom.Contains(word)  && nString[word] == count)
                {
                    countFrom.Add(word);
                }

            }

            string famousWord = countFrom[0];
            Console.WriteLine("The most common word is {0}, it is met {1} times.",famousWord,count);
        }
    }


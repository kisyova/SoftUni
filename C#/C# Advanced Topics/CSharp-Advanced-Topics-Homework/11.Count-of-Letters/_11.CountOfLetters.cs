using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CountOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter letters separated by an interval:");
            string lettersString = Console.ReadLine();
            char[] symbol = new char[65536];
            List<char> letterslist = new List<char>(symbol);
            char[] convertedSymbol = letterslist.ToArray();

            for (int i = 0; i < lettersString.Length; i++)
            {
                if (char.IsLetter(lettersString, i))
                {
                    convertedSymbol[lettersString[i]]++;
                }
            }
            for (int i = 0; i < convertedSymbol.Length; i++)
            {
                if (convertedSymbol[i] > 0 && char.IsLetter((char)i))
                {
                    Console.WriteLine("{0} -> {1} times", (char)i, (int)convertedSymbol[i]);
                }
            }
            Console.WriteLine();
        }
    }


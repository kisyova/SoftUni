using System;
using System.Linq;

    class LongestWordInText
    {
        static void Main()
        {
            Console.WriteLine("Enter your text: ");
            string[] text = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            string longestWord = text.OrderByDescending(s => s.Length).First();

            Console.WriteLine("The longest word is " + longestWord);
        }
    }


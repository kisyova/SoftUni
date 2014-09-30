using System;
using System.Linq;

namespace _16.Counting_Word_in_Text
{
    class CountingWordsInText
    {
        static void Main()
        {
            Console.Write("Enter the word you want to search: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            string[] textArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var symbol in text)
            {
                if (!Char.IsLetter(symbol))
                {
                    text = text.Replace(symbol, ' ');
                }
            }
            string wordToLower = word.ToLower();
            int count = textArray.Count(w => w.ToLower() == wordToLower);
            Console.WriteLine(count);
        }
    }
}

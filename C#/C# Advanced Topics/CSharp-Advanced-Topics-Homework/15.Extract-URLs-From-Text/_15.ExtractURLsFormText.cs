using System;
using System.Text.RegularExpressions;

namespace _15.Extract_URLs_From_Text
{
    class ExtractURLsFromText
    {
        static void Main()
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            MatchCollection extract = Regex.Matches(text, @"\b(?:http://|www\.)\S+\b");

            foreach (var url in extract)
            {
                Console.WriteLine(url);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_of_Names
{
    class CountOfNames
    {
        static void Main()
        {
            Console.WriteLine("Enter names separated by an interval: ");
            string[] names = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            
            Dictionary<string, int> dictionary = new Dictionary<string, int> ( );
 
            foreach (var name in names)
            {
                int counter = 0;
                if (dictionary.ContainsKey(name))
                {
                    counter = dictionary[name];
                }
                dictionary[name] = counter + 1;
            }
 
            foreach (KeyValuePair<string, int> item in dictionary.OrderBy(key => key.ToString()))
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
    }
}
}

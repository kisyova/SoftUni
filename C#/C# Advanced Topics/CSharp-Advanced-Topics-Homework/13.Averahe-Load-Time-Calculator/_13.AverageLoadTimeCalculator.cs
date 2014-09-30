using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13.Averahe_Load_Time_Calculator
{
    class AverageLoadTimeCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter your data each on a separate line: ");
            string input = Console.ReadLine();
            
            Dictionary<string, double> sumOfTime = new Dictionary<string, double>();
            Dictionary<string, int> countOfLoads = new Dictionary<string, int>();

            while (input != string.Empty)
            {
                string[] str = input.Split(' ');
                string url = str[2];
                double loadTime = double.Parse(str[3], CultureInfo.InvariantCulture);
                if (!sumOfTime.Keys.Contains(input))
                {
                    sumOfTime[input] = loadTime;
                    countOfLoads[input] = 1;
                }
                else
                {
                    sumOfTime[input] = sumOfTime[input] + loadTime;
                    countOfLoads[input]++;
                }
                url = Console.ReadLine();
            }

            foreach (string url in sumOfTime.Keys)
            {
                Console.WriteLine(url + " --> " + sumOfTime[url] / countOfLoads[url]);
            }

        }
    }
}

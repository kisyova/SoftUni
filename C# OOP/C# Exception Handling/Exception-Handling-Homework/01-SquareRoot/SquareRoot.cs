using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SquareRoot
{
    class SquareRoot
    {

        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double result = Math.Sqrt(num);
                Console.WriteLine("The square root of {0} is {1}", num, result);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number cannot be negative!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}

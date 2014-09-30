using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            var numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                var isValid = true;
                do
                {
                    try
                    {
                        numbers[i] = ReadNumber(start, end);
                        if (i > 0)
                        {
                            if (numbers[i] <= numbers[i - 1])
                            {
                                throw new ArithmeticException();
                            }
                        }

                        isValid = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The number must to be in range [" + start + ".." + end + "]");
                        isValid = false;
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("The number must be greater than " + numbers[i - 1]);
                        isValid = false;
                    }
                } while (isValid);
            }
        }

        public static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new FormatException("You must put an integer!");
            }

            return number;
        }
    }

}

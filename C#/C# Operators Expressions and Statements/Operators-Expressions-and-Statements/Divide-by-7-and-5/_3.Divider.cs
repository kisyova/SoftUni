using System;

    class Divider
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("This number can be divided by 5 and by 7 in the same time.");
            }
            else
            {
                Console.WriteLine("This number cannot be divided by 5 and by 7 in the same time.");
            }
        }
    }


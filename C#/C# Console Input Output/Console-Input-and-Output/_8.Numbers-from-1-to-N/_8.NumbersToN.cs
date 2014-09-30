using System;

    class NumbersToN
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            int interval = 0;
            int i;
            if (number <= 0)
            {
                Console.WriteLine("Wrong input!!! Tne number must pe positive! Try again!");
            }
            else
            {
                for (i = 0; i < number; i++) 
                {
                    interval += 1;
                    Console.WriteLine(interval + "\n");
                }
            }
        }
    }


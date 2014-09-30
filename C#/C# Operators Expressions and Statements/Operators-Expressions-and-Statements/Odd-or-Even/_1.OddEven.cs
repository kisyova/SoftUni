using System;

    class OddEven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            if(number % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }
        }
    }


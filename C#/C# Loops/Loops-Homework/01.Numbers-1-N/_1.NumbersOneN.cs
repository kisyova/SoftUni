using System;

    class NumbersOneN
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number: ");
            uint n = uint.Parse(Console.ReadLine());
            uint i = 0;

            while (i < n)
            {
                i++;
                Console.Write("{0} ",i);
            }

            
        }
    }


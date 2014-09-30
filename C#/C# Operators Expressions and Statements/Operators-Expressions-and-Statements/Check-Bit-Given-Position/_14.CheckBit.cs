using System;

    class CheckBit
    {
        static void Main()
        {
            Console.Write("Input an integer number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Input a position of the bit: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> position;
            bool check = false;
            if (bit == 1)
            {
                check = true;
                Console.WriteLine(check);
            }
            else
            {
                check = false;
                Console.WriteLine(check);
            }
        }
    }


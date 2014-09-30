using System;

    class ExtractBit
    {
        static void Main()
        {
            Console.Write("Input a number: ");
            uint number = uint.Parse(Console.ReadLine());
           
            int position = 3;

            int bit = (int)(number >> position) & 1;

            Console.WriteLine("The bit in the position #{0} of number {1} is {2}.",position,number,bit);
       
        }
    }


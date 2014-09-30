using System;

    class BitInteger
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter p: ");
            int p = int.Parse(Console.ReadLine());

            string bits = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine("The number in bits is: {0}", bits);
            int numberP = Convert.ToInt32(bits);
            int firstMask = 1;
            firstMask = firstMask << p;
            int secondMask = number & firstMask;
 
            if (secondMask != 0)
            {
 
                Console.WriteLine("The bit in position {0} is 1",p);
            }
            else
            {
                Console.WriteLine("The bit in position {0} is 0",p);
            }
        }
    }


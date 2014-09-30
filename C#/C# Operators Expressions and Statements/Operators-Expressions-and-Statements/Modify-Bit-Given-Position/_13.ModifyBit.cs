using System;

class ModifyBit
{
    static void Main()
    {

        int oldBit;
        int result;

        Console.WriteLine("Please input new Bit value 0 or 1:");
        int newBit = int.Parse(Console.ReadLine());
        while ((newBit != 0) && (newBit != 1))
        {
            Console.WriteLine("Please input new Bit value 0 or 1:");
            newBit = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please input integer number:");
        int number = Math.Abs(int.Parse(Console.ReadLine()));

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("Please input position to change:");
        int position = Math.Abs(int.Parse(Console.ReadLine()));

        int mask = (1 << position);
        oldBit = (number & (1 << position)) >> position;

        if (oldBit == newBit)
        {
            Console.WriteLine("Nothing to change!");
        }

        if (oldBit != newBit)
        {
            result = number ^ mask;
            Console.WriteLine(new string('-', 32));
            Console.WriteLine("{0} -> original", Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} -> new", Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("The new number is {0}: ",Convert.ToString(result,8));
        }
    }
}

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long dec = long.Parse(Console.ReadLine());

        string hex = null;

        if (dec == 0)
        {
            Console.WriteLine("0");
        }

        else
        {

            while (dec > 0)
            {
                long rem = dec % 16;
                dec /= 16;

                switch (rem)
                {
                    case 10: hex = "A" + hex; break;
                    case 11: hex = "B" + hex; break;
                    case 12: hex = "C" + hex; break;
                    case 13: hex = "D" + hex; break;
                    case 14: hex = "E" + hex; break;
                    case 15: hex = "F" + hex; break;
                    default: hex = rem + hex; break;
                }

            }
        }

        Console.WriteLine(hex);
    }
}

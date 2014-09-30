using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long dec = long.Parse(Console.ReadLine());
        string binary = null;
        long? rem = 0;

        
        

            while (dec > 0)
            {
                rem = dec % 2;
                binary = rem.ToString() + binary;
                dec /= 2;
            }

            Console.WriteLine(binary);
        }
    }


using System;

    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter a hexadecimal number: ");
            string hex = Console.ReadLine();

            long dec = 0;
            long hexadecimal = 1;

            for(int index = hex.Length - 1; index >= 0; index--)
            {
                int numberHex;
                    
                switch(hex[index])
                {
                        case 'A': numberHex = 10; break;
                        case 'B': numberHex = 11; break;
                        case 'C': numberHex = 12; break;
                        case 'D': numberHex = 13; break;
                        case 'E': numberHex = 14; break;
                        case 'F': numberHex = 15; break;
                        default: numberHex = (int)hex[index] - 48; break;
                }

                dec += numberHex * hexadecimal;
                hexadecimal *= 16;
            }

            Console.WriteLine(dec);
        }
    }


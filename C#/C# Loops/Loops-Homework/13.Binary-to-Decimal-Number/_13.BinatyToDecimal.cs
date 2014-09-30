using System;

    class BinatyToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter a number in binary: ");
            string bin = Console.ReadLine();
            int lastDigit = bin.Length - 1;
            long dec = 0;


            for (int index = 0; index < bin.Length; index++,lastDigit--) 
            {
                if (bin[index].ToString().Contains("0")) 
                { }
                else if(bin[index].ToString().Contains("1"))
                {
                    long binary = 1;

                    for (int i = 0; i < lastDigit; i++)
                    {
                        binary *= 2;
                    }
                    dec += binary;
                }
            }
            Console.WriteLine(dec);
        }
    }


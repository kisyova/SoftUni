using System;

    class CheckIfPlayCard
    {
        static void Main()
        {
            Console.Write("Enter a symbol: ");
            string symbol = Console.ReadLine();
            string str2 = "2";
            string str3 = "3";
            string str4 = "4";
            string str5 = "5";
            string str6 = "6";
            string str7 = "7";
            string str8 = "8";
            string str9 = "9";
            string str10 = "10";
            string strJ = "J";
            string strQ = "Q";
            string strK = "K";
            string strA = "A";

            if(symbol == str2 || symbol == str3 || symbol == str4 || symbol == str5 || symbol == str6 || symbol == str7 ||
                symbol == str8 || symbol == str9 || symbol == str10 ||symbol == strJ || symbol == strQ || symbol == strK ||
                symbol == strA)
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }
            } 
    }


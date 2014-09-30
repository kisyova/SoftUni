using System;

    class ExchangeValue
    {
        static void Main()
        {
            // inputing the values
            int a = 5;
            int b = 10;

            // printing the old values
            Console.WriteLine("old a = " + a);
            Console.WriteLine("old b = " + b);

            // exchanging the values
            a = a + b;
            b = a - b;
            a = a - b;

            //printing the new values
            Console.WriteLine("new a = " + a);
            Console.WriteLine("new b = " + b);
            
        }
    }


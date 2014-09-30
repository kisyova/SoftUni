using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int a = int.Parse(Console.ReadLine());

            while (a < 0 || a > 500)
            {
                Console.WriteLine("Wrong input!!!");
                a = int.Parse(Console.ReadLine());
            } 
            Console.Write("Enter the first float number: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter the second float: ");
            float c = float.Parse(Console.ReadLine());

            Console.Write("|{0,-10:X}|", a);
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("|{0,10:F2}", b);
            Console.WriteLine("|{0,-10:F3}|", c);

            
        }
    }


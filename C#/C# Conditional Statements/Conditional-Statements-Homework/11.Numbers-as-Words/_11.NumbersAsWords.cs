using System;

class NumbersAsWords
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int hundreds = number / 100; 
        int tens = (number % 100) / 10; 
        int units = (number % 100) % 10; 
        
        if (number == 0)
        { 
            Console.WriteLine("zero"); 
        }
        
        if (number % 100 == 0)
        {
            switch (hundreds)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }
        }
        else
        {
            switch (hundreds)
            {
                case 1: Console.Write("One hundred and "); break;
                case 2: Console.Write("Two hundred and "); break;
                case 3: Console.Write("Three hundred and "); break;
                case 4: Console.Write("Four hundred and "); break;
                case 5: Console.Write("Five hundred and "); break;
                case 6: Console.Write("Six hundred and "); break;
                case 7: Console.Write("Seven hundred and "); break;
                case 8: Console.Write("Eight hundred and "); break;
                case 9: Console.Write("Nine hundred and "); break;
            }
            
            switch (tens)
            {
                case 1:
                    {
                        switch (units)
                        {
                            case 1: Console.Write("eleven "); break;
                            case 2: Console.Write("twelve "); break;
                            case 3: Console.Write("thirteen "); break;
                            case 4: Console.Write("fourteen "); break;
                            case 5: Console.Write("fifteen "); break;
                            case 6: Console.Write("sixteen "); break;
                            case 7: Console.Write("seventeen "); break;
                            case 8: Console.Write("eighteen "); break;
                            case 9: Console.Write("nineteen "); break;
                            default: Console.WriteLine("ten"); break;
                        }
                    } break;
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("forty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
                default: Console.WriteLine(); break;
            }

            switch (units)
            {
                case 1: Console.WriteLine("one "); break;
                case 2: Console.WriteLine("two "); break;
                case 3: Console.WriteLine("three "); break;
                case 4: Console.WriteLine("four "); break;
                case 5: Console.WriteLine("five "); break;
                case 6: Console.WriteLine("six "); break;
                case 7: Console.WriteLine("seven "); break;
                case 8: Console.WriteLine("eight "); break;
                case 9: Console.WriteLine("nine "); break;
            }
        }
    }

}


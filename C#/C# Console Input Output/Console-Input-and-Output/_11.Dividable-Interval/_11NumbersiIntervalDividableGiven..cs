using System;

class NumbersiIntervalDividableGiven
{
    static void Main()
    {
        Console.Write("Give a start: ");
        uint start = uint.Parse(Console.ReadLine());
        Console.Write("Give an end: ");
        uint end = uint.Parse(Console.ReadLine());
        uint[] arrayOfNumbers = new uint[end];
        int counter = 0;
        uint i = 0;

        if (start != 0 && end != 0)
        {
            for (i = start; i < end; i++)
            {
                if(i % 5 == 0)
                {
                    counter++;
                    arrayOfNumbers[i] = i;
                }
            }
            Console.Write("How many numbers can be divided by 5 in this interval? - ");
            Console.WriteLine(counter + " ");
            
            for (uint d = start; d < end; d++)
            {
                if(arrayOfNumbers[d] != 0)
                {
                    Console.WriteLine("Number: ");
                    Console.WriteLine(arrayOfNumbers[d]);
                }
            }
        }
        else
        {
            Console.WriteLine("Wrong input!!!");
        }
    
        }
        
    }


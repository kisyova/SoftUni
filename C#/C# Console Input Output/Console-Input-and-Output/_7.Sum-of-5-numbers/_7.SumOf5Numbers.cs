using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers!");
            Console.Write("First number: ");
            decimal a= decimal.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            decimal b= decimal.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            decimal c= decimal.Parse(Console.ReadLine());
            Console.Write("Fourth number: ");
            decimal d= decimal.Parse(Console.ReadLine());
            Console.Write("Fifth number: ");
            decimal e= decimal.Parse(Console.ReadLine());

            decimal sum = a + b + c + d + e;

            Console.WriteLine("The numbers are {0} {1} {2} {3} {4}",a,b,c,d,e);
            Console.WriteLine("Their sum is {0}.",sum);

            
        }
    }


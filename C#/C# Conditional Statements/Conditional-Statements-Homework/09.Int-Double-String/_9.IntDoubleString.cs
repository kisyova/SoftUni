using System;

    class IntDoubleString
    {
        static void Main()
        {
            Console.Write("Enter a variable (1 for int, 2 for double, 3 for string): ");
            sbyte var = sbyte.Parse(Console.ReadLine());

            switch (var)
            {
                case 1: int firstCohice = int.Parse(Console.ReadLine());
                    Console.WriteLine(firstCohice + 1);
                    break;
                case 2: double secondCohice = double.Parse(Console.ReadLine());
                    Console.WriteLine(secondCohice + 1);
                    break;
                case 3: string thirdCohice = Console.ReadLine();
                    Console.WriteLine(thirdCohice + "*");
                    break;
                default: Console.WriteLine("Wrong input!!!");
                    break;
            }
        }
    }


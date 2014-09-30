using System;

    class RandomNumbers
    {
        static void Main()
        {
            Console.Write("How many random numbers? :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Minimum? :");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Maximum? :");
            int max = int.Parse(Console.ReadLine());

            if (max >= min)
            {
                Random random = new Random();
                for (int i = 1; i <= n; i++)
                {
                    int randomNumber = random.Next(min, max);
                    Console.Write(randomNumber + " ");
                }
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
    }


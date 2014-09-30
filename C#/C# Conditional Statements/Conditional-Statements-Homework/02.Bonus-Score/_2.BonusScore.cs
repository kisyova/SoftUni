using System;

    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            int bonus;

            if (score >= 1 && score <= 3)
            {
                bonus = score * 10;
                Console.WriteLine(bonus);
            }
            else if (score >= 4 && score <= 6)
            {
                bonus = score * 100;
                Console.WriteLine(bonus);
            }
            else if (score >= 7 && score <= 9)
            {
                bonus = score * 1000;
                Console.WriteLine(bonus);
            }
            else if (score < 1 || score > 9)
            {
                Console.WriteLine("Invalid score!");
            }
        }
    }


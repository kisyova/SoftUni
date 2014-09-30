using System;

    class DifferenceBetweenDays
    {
        static void Main()
        {
            Console.Write("Enter the first date in dd.MM.yyyy: ");
            DateTime startDay = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the second date in dd.MM.yyyy: ");
            DateTime endDay = DateTime.Parse(Console.ReadLine());
            double days = Difference(startDay, endDay);

            Console.WriteLine("The difference is between {0} and {1} is {2} days.",startDay,endDay,days);

        }

        private static double Difference(DateTime start,DateTime end)
        {
            TimeSpan span = end - start;
            double difference = span.TotalDays;

            return difference;
        }
    }


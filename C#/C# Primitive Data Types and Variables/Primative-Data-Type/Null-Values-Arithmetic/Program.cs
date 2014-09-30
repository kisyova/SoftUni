using System;

    class NullValues
    {
        static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 6;
            int? d = c;
            double e = 6.89;
            double? f = e;

            Console.WriteLine(d);
            Console.WriteLine(f);

        }
    }


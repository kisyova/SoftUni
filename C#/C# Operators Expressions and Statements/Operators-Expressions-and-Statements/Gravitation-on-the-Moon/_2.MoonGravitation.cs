using System;

    class MoonGravitation
    {
        static void Main()
        {
            float earthGravitation = 9.81f;
            double moonGravitation = 0.17 * earthGravitation;

            Console.WriteLine("Gravitation on Moon is: " + moonGravitation + "m/s");

            Console.WriteLine("Input your weight: ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = 0.17 * weightOnEarth;

            Console.WriteLine("Your weight on the Moon is: " + weightOnMoon);
            
        }
    }


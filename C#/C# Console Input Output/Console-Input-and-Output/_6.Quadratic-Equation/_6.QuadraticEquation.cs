using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter value for c: ");
            double c = double.Parse(Console.ReadLine());

            if(a == 0)
            {
                Console.WriteLine("Wrong input!!! The a-coefficient cannot be 0!");
            }
            else
            {
                double formula = (b * b - 4 * a * c) / (4 * a * a);

                if(formula < 0)
                {
                    Console.WriteLine("No real roots!");
                }
                else
                {
                    if(formula == 0)
                    {
                        double root = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                        Console.WriteLine("root1 = root2 = {0}",root);
                    }
                    else
                    {
                        double root1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                        double root2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                        Console.WriteLine("root1 = {0}, root2 = {1}",root1,root2);
                    }
                }
            }
        }
    }


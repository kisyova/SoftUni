using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FractionCalculator
{
    class FractionCalculator
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(22, 7);
            Fraction f2 = new Fraction(40, 4);
            Fraction operatorPlus = f1 + f2;
            Fraction operatorMinus = f1 - f2;

            Console.WriteLine("f1: " + f1);
            Console.WriteLine("f2: " + f2);
            Console.WriteLine("Numerator: " + operatorPlus.Numerator);
            Console.WriteLine("Denominator: " + operatorPlus.Denominator);
            Console.WriteLine("Result +: " + operatorPlus);
            Console.WriteLine("Result -: " + operatorMinus);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.denominator = denominator;
        }

        public long Numerator {
            get { return this.numerator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                    throw new ArgumentOutOfRangeException("The number must be in range [-9223372036854775808…9223372036854775807]",
                        "Numerator");
                this.numerator = value;
            }
        }

        public long Denominator {
            get { return this.denominator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                    throw new ArgumentOutOfRangeException("The number must be in range [-9223372036854775808…9223372036854775807]",
                        "Denominator");
                if (value == 0)
                    throw new ArgumentException("The denominator cannot be 0!", "Denominator");
                this.denominator = value;
            }
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            checked
            {
                long numerator = f1.numerator * f2.denominator - f1.denominator * f2.numerator;
                long denominator = f1.denominator * f2.denominator;
                return new Fraction(numerator, denominator);
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            checked
            {
                long numerator = f1.numerator * f2.denominator + f1.denominator * f2.numerator;
                long denominator = f1.denominator * f2.denominator;
                return new Fraction(numerator, denominator);
            }
        }

        public override string ToString()
        {
            return ((decimal)numerator / denominator).ToString();
        }

    }
}

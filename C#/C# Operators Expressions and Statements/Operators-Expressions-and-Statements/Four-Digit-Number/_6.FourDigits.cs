using System;

    class FourDigits
    {
        static void Main()
        {
            int abcd = int.Parse(Console.ReadLine()); //inputing the four-digit integer number
            int firstDigit = abcd / 1000;
            int secondDigit = (abcd / 100) % 10;
            int thirdDigit = (abcd % 100) / 10;
            int fourthDigit = abcd % 10;

            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("The sum of the number's digits is: ");
            Console.WriteLine(sum);

            Console.WriteLine("The number in reversed order looks like this: {0}{1}{2}{3}",fourthDigit,thirdDigit,secondDigit,firstDigit);

            Console.WriteLine("The last digit in the first position: {0}{1}{2}{3}", fourthDigit,firstDigit,secondDigit,thirdDigit);

            Console.WriteLine("Exchanging the second and the third digit: {0}{1}{2}{3}",firstDigit,thirdDigit,secondDigit,fourthDigit);
            
        }

    }


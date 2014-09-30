using System;

    class ThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Input a number: ");
            int number1 = int.Parse(Console.ReadLine()); //inputing an integer number
            int number2 = number1 / 100; //dividing it by 100 so we can get the second digit from left to right
            int number3 = number2 % 10; //then we divide it by 10 and the important here is what is the rest
            
            if(number3 == 7)
            {
                Console.WriteLine("Correct number!");
            }
            else
            {
                Console.WriteLine("Incorrect! Try again.");
            }
        }
    }


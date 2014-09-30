using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your date of birth ");
            DateTime today = DateTime.Now; //днешната дата
            DateTime birthday = DateTime.Parse(Console.ReadLine()); //въвеждаме датата, на която сме родени
            Console.WriteLine("Your age now is " + (today.Year - birthday.Year)); //пресмятаме на колко години сме на днешната дата
            Console.WriteLine("Your age after 10 years wll be " + (today.Year - birthday.Year + 10)); //Пресмятаме на колко години ще сме след 10 години
        }
    }


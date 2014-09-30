using System;

    class ComparingFloats
    {
        static void Main()
        {
            //Initializing two floats
            float numberA = 5.3f;
            float numberB = 6.01f;

            float eps = Math.Abs(numberA * .000001f); //Define the tolerance for variation in their values
            if (Math.Abs(numberA - numberB) <= eps) //Compare tha values and print the result
            {
                Console.WriteLine("The floats are equal");
            }
            else
            {
                Console.WriteLine("The floats are NOT equal");
            }
        }
    }


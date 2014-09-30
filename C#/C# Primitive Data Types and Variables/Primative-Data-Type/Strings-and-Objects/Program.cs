using System;

    class StringsObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object exc = "!";
            string end = (string)exc;

            Console.WriteLine(hello + " " + world + " " + end);
        }
    }


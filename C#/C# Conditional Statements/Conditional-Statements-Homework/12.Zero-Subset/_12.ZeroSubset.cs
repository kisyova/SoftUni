using System;

    class ZeroSubset
    {
        static void Main()
        {
            Console.Write("Enter five integer numbers: ");
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            int numFive = int.Parse(Console.ReadLine());

            if (numOne + numTwo == 0) Console.WriteLine("{0} + {1} = 0", numOne, numTwo);
            else if (numOne + numThree == 0) Console.WriteLine("{0} + {1} = 0", numOne, numThree);
            else if (numOne + numFour == 0) Console.WriteLine("{0} + {1} = 0", numOne, numFour);
            else if (numOne + numFive == 0) Console.WriteLine("{0} + {1} = 0", numOne, numFive);
            else if (numOne + numTwo + numThree == 0) Console.WriteLine("{0} + {1} + {2} = 0", numOne, numTwo, numThree);
            else if (numOne + numTwo + numFour == 0) Console.WriteLine("{0} + {1} + {2} = 0", numOne, numTwo, numFour);
            else if (numOne + numTwo + numFive == 0) Console.WriteLine("{0} + {1} + {2} = 0", numOne, numTwo, numThree);
            else if (numOne + numThree + numFour == 0) Console.WriteLine("{0} + {1} + {2} = 0", numOne, numThree, numFour);
            else if (numOne + numThree + numFive == 0) Console.WriteLine("{0} + {1} + {2} = 0", numOne, numThree, numFive);
            else if (numOne + numFour + numFive == 0) Console.WriteLine("{0} + {1} + {2} = 0", numOne, numFour, numFive);
            else if (numOne + numTwo + numThree + numFour == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", numOne, numTwo, numThree, numFour);
            else if (numOne + numTwo + numThree + numFive == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", numOne, numTwo, numThree, numFive);
            else if (numOne + numTwo + numFour + numFive == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", numOne, numTwo, numFour,numFive );
            else if (numOne + numThree + numFour + numFive == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", numOne, numThree, numFour, numFive);
            else if (numTwo + numThree == 0) Console.WriteLine("{0} + {1} = 0", numTwo, numThree);
            else if (numTwo + numFour == 0) Console.WriteLine("{0} + {1} = 0", numTwo, numFour);
            else if (numTwo + numFive == 0) Console.WriteLine("{0} + {1} = 0", numTwo, numFive);
            else if (numTwo + numThree + numFour == 0) Console.WriteLine("{0} + {1} + {2} = 0", numTwo, numThree, numFour);
            else if (numTwo + numThree + numFive == 0) Console.WriteLine("{0} + {1} + {2} = 0", numTwo, numThree, numFive);
            else if (numTwo + numFour + numFive == 0) Console.WriteLine("{0} + {1} + {2} = 0", numTwo, numFour, numFive);
            else if (numTwo + numThree + numFour + numFive == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", numTwo, numThree, numFour, numFive);
            else if (numThree + numFour == 0) Console.WriteLine("{0} + {1} = 0", numThree, numFour);
            else if (numThree + numFive == 0) Console.WriteLine("{0} + {1} = 0", numThree, numFive);
            else if (numThree + numFour + numFive == 0) Console.WriteLine("{0} + {1} + {2} = 0", numThree, numFour, numFive);
            else if (numFour + numFive == 0) Console.WriteLine("{0} + {1} = 0", numFour, numFive);
            else if (numOne + numTwo + numThree + numFour + numFive == 0) Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", 
                numOne, numTwo, numThree, numFour, numFive);
            else
            {
                Console.WriteLine("No zero subset!");
            }
        }
    }


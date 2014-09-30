using System;

    class SortingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter how many integers you want to sort: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. ",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

                Array.Sort<int>(numbers);
                Console.WriteLine("Sorted numbers: ");
                
            for (int i = 0; i < n; i++)
			{
			 Console.WriteLine(numbers[i]);
			}

            }
        }

    


using System;

    class OddOrEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter value for N: ");
            int n=int.Parse(Console.ReadLine());
           
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            int oddProduct = 1;
            for (int i = 0; i <= n-1  ; i += 2)
            {
               oddProduct *= numbers[i];
            }
           
            int evenProduct = 1;
                for (int i = 1; i <= n - 1; i += 2)
                {
                    evenProduct *= numbers[i];
                }
           
           if (oddProduct == evenProduct)
           {
               Console.WriteLine("Yes!");
               Console.WriteLine("Product = {0}", evenProduct);
           }
           
               else
           {
               Console.WriteLine("No!");
               Console.WriteLine("odd_product = {0}", oddProduct);
               Console.WriteLine("even_product = {0}", evenProduct);
           }
 
        }
    }


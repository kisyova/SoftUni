using System;

    class PrintSequence
    {
        static void Main()
        {
            const int first = 2; //първият елемент
            for(int i=0;i<=10;i++) //цикъл за първите 10 числа
                {
                    int n = i + first; //за всеки следващ член на редицата
                    if (n % 2 != 0) //проверка за четност
                        n *= -1; //смяна на знаците

                    Console.WriteLine(n);
                }
                
                
        }
    }


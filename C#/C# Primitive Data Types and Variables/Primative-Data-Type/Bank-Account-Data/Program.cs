using System;

    class BankAccount
    {
        static void Main()
        {
            string firstName = "Mike";
            string middleName = "Calvin";
            string lastName = "Harris";
            int balance = 25000;
            string bankName = "International Bank";
            string iban = "GB29 NWBK 6016 1331 9268 19";
            ulong firstCreditCardNumber = 1569834785236978;
            ulong secondCreditCardNumber = 9867536984130264;
            ulong thirdCreditCardNumber = 5803169025713605;

            Console.WriteLine("Bank account data: ");
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Middle name: " + middleName);
            Console.WriteLine("Lat name: " + lastName);
            Console.WriteLine("Amount of money : " + balance);
            Console.WriteLine("Name of the bank: " + bankName);
            Console.WriteLine("International Bank Account Number: " + iban);
            Console.WriteLine("Numers of the client's credit cards: " + firstCreditCardNumber + ", " + secondCreditCardNumber + ", " + thirdCreditCardNumber);

        }
    }


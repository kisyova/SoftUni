using System;

    class CompanyInformation
    {
        static void Main()
        {
            Console.Write("Entter a cmpany name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter the company adress: ");
            string addressCompany = Console.ReadLine();
            Console.Write("Enter the company phone number: ");
            string phoneNumberCompany = Console.ReadLine();
            Console.Write("Enter the company fax number: ");
            string faxNumberComany = Console.ReadLine();
            Console.Write("Enter the company website: ");
            object websiteCompany = Console.ReadLine();
            Console.Write("Enter the company's manager first name: ");
            string firstNameManager = Console.ReadLine();
            Console.Write("Enter the company's manager last name: ");
            string lastNameManager = Console.ReadLine();
            Console.Write("Enter the age of the company's manager: ");
            byte ageManager = byte.Parse(Console.ReadLine());
            Console.Write("Enter the phone number of the manager: ");
            string phoneNumberManager = Console.ReadLine();
            //we use strings for numbers so the console will print them right if they start with "+" or "0"

            Console.WriteLine("The company {0} is situated in {1}. You can contact the company by phone - {2}, or fax - {3}. For more information, you can visit the website {4}.",
                companyName,addressCompany,phoneNumberCompany,faxNumberComany,websiteCompany);
            Console.WriteLine("If you have any questions you can get in touch with the manager {0} {1}({2} years old) personally or call him on {3}.",
                firstNameManager,lastNameManager,ageManager,phoneNumberManager);

        }
    }


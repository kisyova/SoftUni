using System;

    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Is it time for beer? :");
            string wantBeer = Console.ReadLine();
            DateTime wantBeerDT;

            if (DateTime.TryParse(wantBeer, out wantBeerDT))
            {
                string startTimeAM = "12:00 AM";     
                string endTimeAM = "03:00 AM";  
                DateTime startTimeAMDT = DateTime.Parse(startTimeAM);
                DateTime endTimeAMDT = DateTime.Parse(endTimeAM);
                
                string startTimePM = "01:00 PM"; 
                string endTimePM = "11:49 PM"; 
                DateTime startTimePMDT = DateTime.Parse(startTimePM);
                DateTime endTimePMDT = DateTime.Parse(endTimePM);
                if (wantBeerDT >= startTimePMDT && wantBeerDT <= endTimePMDT)
                {
                    Console.WriteLine("BEER TIME");
                }
                else if (wantBeerDT >= startTimeAMDT && wantBeerDT < endTimeAMDT)
                {
                    Console.WriteLine("BEER TIME");
                }
                else 
                {
                    Console.WriteLine("NON-BEER TIME");
                }
            }
            else 
            {
                Console.WriteLine("INVALID TIME");
            }
        }
    }


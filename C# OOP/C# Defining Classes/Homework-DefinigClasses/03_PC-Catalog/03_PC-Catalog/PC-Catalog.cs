using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class PC_Catalog
    {
        static void Main(string[] args)
        {
            Component motherboard = new Component("Toshiba C660D", 420);
            Component processor = new Component("Intel i7 4900K", 1800);
            Component graphicsCard = new Component("AMD Radeon HD 9800", 7300);
            Component RAM = new Component("32 GB", 300);
            Component HDD = new Component("1TB 7200rpm", 170);
            Computer computer = new Computer("Toshiba", new List<Component>() { motherboard, processor, graphicsCard, RAM, HDD });
            
            Console.WriteLine(computer.ToString());
        }
    }
}

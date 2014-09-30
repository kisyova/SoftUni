using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Battery lion = new Battery("Li-Ion, 4 Cells, 10.8 Volt");
            Battery hp = new Battery("HP Compaq, 6 Cells", (float)4.2);
            Laptop laptop1 = new Laptop("Lenovo Yoga 2 Pro", (decimal)2259.00, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8,
                "Intel HD Graphics 4400", 128, lion, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
            Laptop laptop2 = new Laptop("HP 250 G2", (decimal)699.00);

            Console.WriteLine(laptop1.ToString());
            Console.WriteLine();
            Console.WriteLine(laptop2.ToString());

        }
    }
}

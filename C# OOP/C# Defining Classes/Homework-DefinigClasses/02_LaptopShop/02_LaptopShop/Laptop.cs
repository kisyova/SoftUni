using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private int hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, int ram = 0,
            string graphicCard = null, int hdd = 0, Battery battery = null, string screen = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
            this.Screen = screen;

        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Model cannot be NULL!");
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price cannot be NULL or below 0!");
                this.price = value;
            }
        }
        public string Manufacturer {
            get { return this.manufacturer; }
            set
            {
                if (value == null || value.Length < 1)
                    throw new ArgumentException("Invalid input for manufacturer!");
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Length < 1)
                    throw new ArgumentException("Invalid input for processor!");
                this.processor = value;
            }
        }

        public int Ram {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("RAM must be positive integer!");
                this.ram = value;
            }
        }

        public string GraphicCard {
            get { return this.graphicCard; }
            set
            {
                if (value != null && value.Length < 1)
                    throw new ArgumentException("Invalid input for graphic card!");
                this.graphicCard = value;
            }
        }

        public int Hdd {
            get { return this.hdd; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("HDD must be positive integer!");
                this.hdd = value;
            }
        }

        public string Screen {
            get { return this.screen; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid input for screen!");
                    this.screen = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("model: " + this.Model);
            if (this.Manufacturer != null)
            {
                result.AppendLine("manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                result.AppendLine("processor: " + this.Processor);
            }
            if (this.Ram > 0)
            {
                result.AppendLine("RAM: " + this.Ram + " GB");
            }
            if (this.GraphicCard != null)
            {
                result.AppendLine("graphic card: " + this.GraphicCard);
            }
            if (this.Hdd > 0)
            {
                result.AppendLine("HDD: " + this.Hdd + "GB SSD");
            }
            if (this.Screen != null)
            {
                result.AppendLine("Screen: " + this.Screen);
            }
            if (Battery != null)
            {
                result.AppendLine(this.Battery.ToString());
            }
            result.AppendLine("price: " + this.Price + " lv.");
            return result.ToString();
        }
    }
}

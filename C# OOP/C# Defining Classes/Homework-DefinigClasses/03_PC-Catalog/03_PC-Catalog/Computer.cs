using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Computer
    {
        private string name;
        private List<Component> components = new List<Component>();
        public double Price = 0;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
            foreach (Component component in Components)
            {
                Price += component.Price;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The name cannot be NULL!", "Name");
                this.name = value;
            }
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Components cannot be null!", "Components");
                this.components = value;
            }
    }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("COMPUTER\n");
            if (this.Name != null)
            {
                result.AppendLine("name: " + this.Name);
            }
            foreach (Component component in Components)
            {
                result.AppendLine(component.Name + ": " + component.Price);
            }
            result.AppendLine("Total price: " + this.Price);
            
            return result.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Component
    {
        private string name;
        private double price;
        private string details;

        public Component(string name, double price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public Component(string name, double price) : this(name, price, null) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name cannot be NULL!");
                this.name = value;
            }
        }

        public double Price {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The price must be positive number!", "Price");
                this.price = value;
            }
        }

        public string Details {
            get { return this.details; }
            set
            {
                if (value != null && value == "")
                    throw new ArgumentException("The details cannot be null", "Details");
                this.details = value;
            }
        }
    }
}

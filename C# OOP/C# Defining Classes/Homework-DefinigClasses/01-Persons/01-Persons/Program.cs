using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public Person(string name, int age) : this(name, age, null) { }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name!");
                this.name = value;
            }
        }

        public int Age {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 101)
                    throw new ArgumentOutOfRangeException("Age is out of range!");
                this.age = value;
            }
            }

        public string Email {
            get { return this.email; }
            set
            {
                if (value != null && (value.Length == 0 || !value.Contains("@")))
                    throw new ArgumentException("Invalid email address!");
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("name: {0}\n age: {1}\n", this.Name, this.Age) + (this.Email == null ? "" : "email: " + this.Email + "\n");
        }

      
    }
}

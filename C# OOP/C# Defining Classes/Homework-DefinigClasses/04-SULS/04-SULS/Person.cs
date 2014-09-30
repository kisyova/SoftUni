using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.Age = age;
        }

        public string FirstName {
            get { return this.firstName; }
            set
            {
                if (value == null || value.Length < 2)
                    throw new ArgumentException("Invalid input for first name", "First name");
                this.firstName = value;
            }
        }
        public string LastName {
            get { return this.lastName; }
            set
            {
                if (value == null || value.Length < 2)
                    throw new ArgumentException("Invalid input for last name", "Last name");
                this.lastName = value;
            }
        }

        public int Age {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Invalid input for age", "Age");
                this.age = value;
            } 
        }

        public override string ToString()
        {
            return string.Format("{0}: Name: {1} {2}, {3} years old", GetType().Name, this.FirstName, this.LastName, this.Age);
        }
    }
}

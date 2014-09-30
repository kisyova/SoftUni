using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class Student : Person
    {
        
        private string studentNumber;
        private double grades;

        public Student(string firstName, string lastName, string studentNumber, int age = 0) : base(firstName, lastName, age) 
        { 
            this.StudentNumber = studentNumber;
        }

        public Student(string firstName, string lastName, string studentNumber, double grades, int age = 0)
            : this(firstName, lastName, studentNumber, age)
        {
            this.Grades = grades;
        }

        public Student(string firstName, string lastName, int age = 0) : base(firstName, lastName, age) { }

        public string StudentNumber {
            get { return this.studentNumber; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Student number cannot be null!", "Student number");
                this.studentNumber = value;
            }
            }
        public double Grades {
            get { return this.grades; }
            set { this.grades = value; }
        }

       
    }

}

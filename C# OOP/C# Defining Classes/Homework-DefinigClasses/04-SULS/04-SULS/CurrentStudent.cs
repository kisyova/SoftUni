using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class CurrentStudent : Student
    {
        private IList<String> currentCourse;

        public CurrentStudent(string firstName, string lastName, string studentNumber, double grades, int age = 0)
            : base(firstName, lastName, studentNumber, grades, age)
        {
            this.CurrentCourse = new List<String>();
        }

        public IList<String> CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Invalid input for current course");
                this.currentCourse = value;
            }
        }
        public override string ToString()
        {
            string result = base.ToString();
            string courses = string.Join(", ", this.CurrentCourse);
            return result + string.Format(", Course: {0}", this.CurrentCourse);
        }
    }
}

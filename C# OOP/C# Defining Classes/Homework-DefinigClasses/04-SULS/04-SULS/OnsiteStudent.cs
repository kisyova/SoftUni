using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class OnsiteStudent : CurrentStudent
    {
        private int visits;

        public OnsiteStudent(string firstName, string lastName, string studentNumber, double grades, int age = 0, int visits = 0) :
            base(firstName, lastName, studentNumber, grades, age)
        {
            this.Visits = visits;
        }
        public int Visits {
            get { return this.visits; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Visits cannot be null");
                this.visits = value;
            }
        }
        public override string ToString()
        {
            string result = base.ToString();
            return result + string.Format("\nVisits: {0}", this.Visits);
        }
    }
}

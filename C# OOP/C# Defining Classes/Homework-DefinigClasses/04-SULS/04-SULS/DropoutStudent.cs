using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class DropoutStudent : Student
    {
        private string reason;

        public DropoutStudent(string firstName, string lastName, string studentNumber, double grades, string reason, int age = 0) :
            base(firstName, lastName, studentNumber, grades, age) 
        {
            this.Reason = reason;
        }

        public string Reason {
            get { return this.reason; }
            set {
                if (value == null)
                    throw new ArgumentException("Reason cannot be null!", "Dropout reason");
                this.reason = value; 
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Dropout reason: {0}", this.Reason);
        }
        public void Reapply(string reason)
        {
            Console.WriteLine(reason.ToString());
        }
    }
}

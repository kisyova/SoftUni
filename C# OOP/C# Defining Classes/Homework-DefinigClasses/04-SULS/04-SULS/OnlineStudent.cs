using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, string studentNumber, double grades, int age = 0) :
            base(firstName, lastName, studentNumber, grades, age) { }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age = 0) : base(firstName, lastName, age) { }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} course is created", courseName);
        }
    }
}

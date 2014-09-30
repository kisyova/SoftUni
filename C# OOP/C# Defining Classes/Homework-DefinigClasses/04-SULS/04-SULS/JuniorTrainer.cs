using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string firstName, string lastName, int age = 0) : base(firstName, lastName, age) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persons
{
    class MainPersons
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() {
                new Person("Filip", 60),
                new Person("Vladi", 22, "vlado_125@abv.bg"),
                new Person("Kati", 20, "kati_10@yahoo.com"),
                new Person("Miro", 45)
            };
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}

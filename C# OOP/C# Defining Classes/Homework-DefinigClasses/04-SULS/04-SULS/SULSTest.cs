using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SULS
{
    class SULSTest
    {
        static void Main(string[] args)
        {
            Trainer nakov = new SeniorTrainer("Svetlin", "Nakov");
            Trainer georgiev = new JuniorTrainer("Vladislav", "Georgiev", 20);

            CurrentStudent pesho = new OnlineStudent("Pesho", "Peshev", "215864", (double)4.256, 20);
            CurrentStudent gosho = new OnsiteStudent("Gosho", "Goshev", "356984", (double)5.897, 21, 15);
            CurrentStudent tedi = new OnsiteStudent("Teodora", "Andreeva", "589023", (double)3.587, 19, 8);

            Student minka = new DropoutStudent("Minka", "Mileva", "658974", (double)2.000, "too low grades", 27);
            Student jelqzka = new DropoutStudent("Jelqzka", "Marinkova", "230156", (double)3.958, "moved to another country", 25);
            Student kateto = new GraduateStudent("Katq", "Gancheva", "125896", (double)5.505, 21);
            Student vladko = new GraduateStudent("Vladimir", "Delchev", "125897", (double)4.089, 22);

            List<Person> people = new List<Person>() {nakov, georgiev, pesho, gosho, tedi, minka, jelqzka, kateto, vladko};
            
            pesho.CurrentCourse.Add("OOP");
            gosho.CurrentCourse.Add("JavaScript Basics");
            tedi.CurrentCourse.Add("C# Basics");

            people.Where(p => p is CurrentStudent).OrderBy(p => ((Student)p).Grades).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}

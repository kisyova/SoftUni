using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static_Members_Namespaces_Homework
{
    class Paths
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting point:");
            Console.WriteLine(Point3D.StartPoint.ToString());
            Console.WriteLine();

            Point3D a = new Point3D("A", 1, 2, 1.5);
            Point3D b = new Point3D("B", -1, 2, 1.5);
            Point3D c = new Point3D("C", 1, -2, 1.5);
            Point3D d = new Point3D("D", 1, 2, -1.5);

            Path3D path = new Path3D(a, b, c, d);
            Console.WriteLine("The points of the path:");
            Console.WriteLine(path.ToString());
            Console.WriteLine();

            Console.WriteLine("The distance between point A and point C:");
            Console.WriteLine(DistanceCalculator.CalculateDistance3D(a,c));
            Console.WriteLine();

            Storage.MakePath("../../user_files/Paths.txt", false, path);
            Storage.MakePath("../../user_files.Paths.txt", true, path);

            var loaded = Storage.LoadPath(@"../../user_files/Paths.txt");
            loaded.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}

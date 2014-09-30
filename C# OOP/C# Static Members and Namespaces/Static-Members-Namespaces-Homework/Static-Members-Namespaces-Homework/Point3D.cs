using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Static_Members_Namespaces_Homework
{
    public class Point3D
    {
        private string name;
        private double x;
        private double y;
        private double z;

        private static readonly Point3D startPoint;

        static Point3D()
        {
            startPoint = new Point3D("start", 0, 0, 0);
        }
        public Point3D(string name, double x, double y, double z)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public string Name {
            get { return this.name; }
            set
            {
                if (value == null || value.Length < 1)
                    throw new ArgumentException("The name cannot be null!", "Name");
                this.name = value;
            }
        }
        public double X {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
        public static Point3D StartPoint {
            get { return Point3D.startPoint; }
        }
        public override string ToString()
        {
            return String.Format("{0}({1:F}, {2:F}, {3:F})", this.Name, this.X.ToString(), this.Y.ToString(), this.Z.ToString());
        }
        public static Point3D Regular(string point)
        {
            Regex regx = new Regex(@"(.+?){(.+?),(.+?),(.+?)}");
            MatchCollection matches = regx.Matches(point);
            var group = (matches[0] as Match).Groups;
            Point3D result = new Point3D(group[1].Value, double.Parse(group[2].Value), double.Parse(group[3].Value), double.Parse(
                group[4].Value));
            return result;
        }
    }
}

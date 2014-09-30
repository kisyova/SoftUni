using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members_Namespaces_Homework
{
    class Path3D
    {
        private IList<Point3D> paths;

        public Path3D(params Point3D[] point3D)
        {
            this.Paths = point3D.ToList();
        }
        public IList<Point3D> Paths
        {
            get { return this.paths; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("The value cannot be null!");
                this.paths = value;
            }
        }
        public int Count
        {
            get { return this.Paths.Count; }
        }
        public Point3D this[int index]
        {
            get { return this.Paths[index]; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("The value cannot be null!");
                this.Paths[index] = value;
            }
        }
        public void Add(Point3D point)
        {
            this.Paths.Add(point);
        }
        public override string ToString()
        {
            var resultString = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                resultString.Append(this[i].ToString());
                if (i != this.Count - 1)
                {
                    resultString.Append(", ");
                }
            }
            return resultString.ToString();
        }
    }
}

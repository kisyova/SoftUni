using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members_Namespaces_Homework
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance3D(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2) + 
                Math.Pow((firstPoint.Z - secondPoint.Z), 2));
            return distance;
        }
    }
}

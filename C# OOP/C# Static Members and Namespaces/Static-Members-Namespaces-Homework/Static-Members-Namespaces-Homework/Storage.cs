using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Static_Members_Namespaces_Homework
{
    static class Storage
    {
        public static void MakePath(string fileName, bool append, Point3D path)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(fileName, append, Encoding.GetEncoding("UTF-8"))) {
                    writer.WriteLine(path.ToString());
                }
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }
        public static List<Path3D> LoadPath(string fileName)
        {
            try
            {
                var paths = new List<Path3D>();
                using (var reader = new StreamReader(fileName, Encoding.GetEncoding("UTF-8")))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Path3D points = new Path3D();
                        var lines = line.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in lines)
                        {
                            points.Add(Point3D.Regular(item));
                        }
                        line = reader.ReadLine();
                        paths.Add(points);
                    }
                }
                return paths;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }
    }
}

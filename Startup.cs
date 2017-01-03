using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_HomeWork_2._1
{
    class Startup
    {
        static void Main()
        {
            // Q1 - Create default point {0, 0, 0}
            Point3D point1 = new Point3D(1, 2, 3);
            // Q1 - Create test point {2, 2, 2} 
            Point3D point2 = new Point3D(2, 2, 2);
            // Print the 2 created points
            Console.WriteLine("Coordinates of point 1 : {0}", point1);
            Console.WriteLine("Coordinates of point 2 : {0}",point2);
            // Q2 - Test the Point0
            Console.Write("The start of the coordiante system: ");
            Console.WriteLine(String.Join(", ", Point3D.Point0));
            // Q3 - Print the distance
            Console.WriteLine("Distance bitween point 1 and 2 : {0}", Distance.DistanceCalc(point1, point2));
            Console.WriteLine();
            Console.WriteLine();

            // Q4 - Create path and add point1 and point2 
            Path firstpath = new Path();
            firstpath.AddPoint(point1);
            firstpath.AddPoint(point2);
            // Q4 - Print the 2 points
            Console.WriteLine("Here are the {0} points holded in the path firstpath:", firstpath.Paths.Count);
            for (int i = 0; i < firstpath.Paths.Count; i++)
            {
                Console.WriteLine(firstpath.Paths[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Q5 - Create file with the path above point1 and point2 in the current directory with name PathFile.txt
            PathStorage.SavePath(firstpath);
            Console.WriteLine("The path is saved to {0}", Environment.CurrentDirectory + @"\PathFile.txt");
            Console.WriteLine();
            Console.WriteLine();

            // Q5 - Load the PathFile.txt and create a new path with the data from the file
            Path newpath = new Path();
            newpath = PathStorage.LoadPaths("PathFile.txt", newpath);
            Console.WriteLine("Here are the {0} points holded in the path newpath loaded form the file {1}:", newpath.Paths.Count, Environment.CurrentDirectory + @"\PathFile.txt");
            for (int i = 0; i < newpath.Paths.Count; i++)
            {
                Console.WriteLine(newpath.Paths[i]);
            }
            Console.WriteLine();
            Console.WriteLine();




        }
    }
}

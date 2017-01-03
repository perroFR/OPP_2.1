using System.Collections.Generic;

namespace OPP_HomeWork_2._1
{
    class Path
    {
        public List<Point3D> Paths { get; set; }

        public Path()
        {
            this.Paths = new List<Point3D>();
        }
        public void AddPoint(Point3D point)
        {
            this.Paths.Add(point);
        }
    }
}

using System;

namespace OPP_HomeWork_2._1
{
    static class Distance
    {
        public static double DistanceCalc(Point3D first, Point3D second)
        {
            return Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2) + Math.Pow(second.Z - first.Z, 2));
        }
    }
}

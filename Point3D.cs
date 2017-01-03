namespace OPP_HomeWork_2._1
{
    struct Point3D
    {
        // The start point could be created as point3d with the default constructor
        //public static readonly Point3D Point0 = new Point3D();

        // Create the 0 point as asked by field and property
        private static readonly int[] point0 = new int[] {0, 0, 0 };

        public static int[] Point0
        {
            get { return point0; }
        }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Here are the 3 cordinates of the point
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // Override the string method to print the coordinates as {X, Y, Z}
        public override string ToString()
        {
            return "{" + X + ", " + Y + ", " + Z + "}";
        }
    }
}

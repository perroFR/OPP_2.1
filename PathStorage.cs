using System;

namespace OPP_HomeWork_2._1
{
    static class PathStorage
    {
        public static void SavePath(Path paths)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter( Environment.CurrentDirectory + @"\PathFile.txt", true))
            {
                for (int i = 0; i < paths.Paths.Count; i++)
                {
                    file.WriteLine(paths.Paths[i]);
                }                                                                  
            }
        }


        public static Path LoadPaths(string filename, Path newpath)
        {
            string[] lines = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\" + filename);
            Point3D point = new Point3D();
            char[] delimiters = new char[] { '\r', '\n', ' ', ',', '{', '}' };
            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbers = lines[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                point.X = int.Parse(numbers[0]);
                point.Y = int.Parse(numbers[1]);
                point.Z = int.Parse(numbers[2]);

                newpath.AddPoint(point);
            }

            return newpath;
        }
        
    }
}

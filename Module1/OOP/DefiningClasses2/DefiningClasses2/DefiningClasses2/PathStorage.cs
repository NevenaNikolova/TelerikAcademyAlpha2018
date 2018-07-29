using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DefiningClasses2
{
    public static class PathStorage
    {
        public static void SavePath(string filePath, Path path)
        {
            //File.WriteAllText(filePath, path.PointsList.ToString());

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var p in path.PointsList)
                {
                    writer.WriteLine(p);
                }
            }
        }

        public static void LoadPath(string filePath)
        {            
            using (StreamReader reader = new StreamReader(filePath))
            {              
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }
    }
}

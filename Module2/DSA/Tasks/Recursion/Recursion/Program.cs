using System;
using System.IO;

namespace ListAllFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            ListAllFiles(".", "*.cs");
        }


        public static void ListAllFiles(string dir, string searchPattern)
        {
            try
            {
                var files = Directory.GetFiles(dir, searchPattern);
                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }
                var subDirectories = Directory.GetDirectories(dir);
                foreach (var item in subDirectories)
                {
                    ListAllFiles(item, searchPattern);
                }
            }
            catch (Exception)
            {
                throw new Exception();
                
            }

            //Write code here to list all files in all subdirectories recursively
            //use Directory.GetFiles(dir, searchPattern);
            //and Directory.GetDirectories(dir); 
        }

    }
}



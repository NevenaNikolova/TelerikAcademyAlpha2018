using System;

namespace DefiningClasses2
{
    class StartUp
    {
        static void Main()
        {
            Point3D instance1 = new Point3D(2, 5, 8);
            Point3D instance2 = new Point3D(2.5, 3.8, 8.5);

            var path = new Path();
            path.AddPoint(instance1);
            path.AddPoint(instance2);

           PathStorage.SavePath(@"../../text.txt", path);
           PathStorage.LoadPath(@"../../text.txt");
        
           
        }
    }
}

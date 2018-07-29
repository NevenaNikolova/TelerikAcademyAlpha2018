using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses2
{
    public class Path
    {
       private List<Point3D> pointsList;

        public Path()
       {
            this.PointsList = new List<Point3D>();
       }
        public List<Point3D> PointsList
        {
            get { return this.pointsList; }
            set { this.pointsList = value; }
        }

        public void AddPoint(Point3D p)
        {
            this.pointsList.Add(p);
        }

        public void RemovePoint(Point3D p)
        {
            this.pointsList.Remove(p);
        }
        public override string ToString()
        {
            return string.Join("\n", PointsList);
        }
    }
}

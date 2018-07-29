using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses2
{
    public struct Point3D
    {
        private static readonly Point3D startPoint = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }


        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }


        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public override string ToString()
        {
            return string.Format("PointX= {0:F2}\tPointY= {1:F2}\tPointZ= {2:F2}", 
                this.X, this.Y, this.Z);
        }
        public static Point3D StartPoint
        {
            get { return Point3D.startPoint; }
        }

    } 
}

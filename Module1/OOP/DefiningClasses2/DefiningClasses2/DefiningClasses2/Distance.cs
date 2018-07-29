using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses2
{
    static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            var result = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                                        (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) +
                                        (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
            return result;
        }
    }
}

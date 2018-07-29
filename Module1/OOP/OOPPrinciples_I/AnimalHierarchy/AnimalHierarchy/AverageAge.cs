using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public static class AverageAge
    {
        public static double CalculateAverageAge(List<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}

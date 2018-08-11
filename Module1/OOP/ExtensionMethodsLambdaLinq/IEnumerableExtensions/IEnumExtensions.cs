using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IEnumerableExtensions
{
    public static class IEnumExtensions
    {
        public static T SumExtension<T>(this IEnumerable<T> numbers)
        {
            T result = default(T);

            foreach (var n in numbers)
            {
                result += (dynamic)n;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> numbers)
        {
           var result = (dynamic)1;

            foreach (var item in numbers)
            {
                result *= item;
            }
            return result;
        }

        public static T MinValue<T>(this IEnumerable<T> numbers)
        {          
            return numbers.Min();
        }

        public static T MaxValue<T>(this IEnumerable<T> numbers)
        {
            return numbers.Max();
        }

        public static double AvarageValue<T>(this IEnumerable<T> numbers)
        {
            double result = (dynamic)numbers.SumExtension() /(double)numbers.Count();
            return result;
        }
      
    }
}

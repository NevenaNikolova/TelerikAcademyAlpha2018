using System;
using System.Collections.Generic;

namespace IEnumerableExtensions
{
    class IEnumerableTest
    {
        static void Main()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4 };
            var s = nums.SumExtension();
            Console.WriteLine(s);

            var product = nums.Product();
            Console.WriteLine(product);

            Console.WriteLine(nums.MinValue());
            Console.WriteLine(nums.MaxValue());
            Console.WriteLine(nums.AvarageValue());
        }
    }
}

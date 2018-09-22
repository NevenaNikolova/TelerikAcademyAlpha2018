using System;
using System.Linq;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = -1;

            if (n == 1)
            {
                index = 0;
            }
            else if (nums[nums.Length - 1] == nums.Max())
            {
                index = nums.Length - 1;
            }
            else
            {
                for (int i = 1; i < nums.Length - 2; i++)
                {
                    if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
            }
            Console.WriteLine(index);
        }
    }
}

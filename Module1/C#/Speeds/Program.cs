using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main()
        {
            int cars = int.Parse(Console.ReadLine());
            int firstSpeed = int.Parse(Console.ReadLine());

            int speed = firstSpeed;

            int groupCount = 1;
            int maxCount = 1;
            int sum = firstSpeed;
            int maxSum = 0;

            for (int i = 1; i < cars; i++)
            {
                speed = int.Parse(Console.ReadLine());

                if (speed > firstSpeed)
                {
                    groupCount++;
                    sum += speed;
                }
                else
                {
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    firstSpeed = speed;
                    sum = speed;
                    groupCount = 1;
                }

                if (groupCount > maxCount)
                {
                    maxCount = groupCount;
                    maxSum = sum;
                }
                else if (groupCount == maxCount)
                {
                    maxSum = Math.Max(maxSum, sum);
                }
            }

            Console.WriteLine(maxSum);

        }
    }
}

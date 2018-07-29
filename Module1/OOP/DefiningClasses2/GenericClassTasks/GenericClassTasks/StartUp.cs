using System;

namespace GenericClassTasks
{
    class StartUp
    {
        static void Main()
        {
            var nums = new GenericList<int>(2);
            nums.AddElement(1);           
            nums.AddElement(2);
            nums.AddElement(3);
            Console.WriteLine(nums);
            var byInd=nums.AccessByIndex(2);
            Console.WriteLine(byInd);
            Console.WriteLine("test");
            int index = nums.FindElementByValue(2);
            Console.WriteLine(index);
            nums.InsertAt(1,9);
            Console.WriteLine(nums);
            Console.WriteLine(nums.MinValue());
            Console.WriteLine(nums.MaxValue());

            Matrix<int> matrix = new Matrix<int>(4, 5);
            matrix[2, 2] = 10;
            Console.WriteLine(matrix);

        }
    }
}

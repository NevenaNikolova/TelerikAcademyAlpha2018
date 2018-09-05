using System;

namespace _11.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> test = new LinkedList<int>();
            test.AddFirst(2);
            test.AddFirst(3);
            test.AddLast(6);
            test.RemoveFirst();
            test.RemoveLast();

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}

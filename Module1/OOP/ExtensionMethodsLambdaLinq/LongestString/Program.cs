using System;
using System.Linq;

namespace LongestString
{
    class Program
    {
        static void Main()
        {
            string[] strings = new string[] { "Last", "task", "from", "the", "homework", "yees!" };

            var longestString = strings
                .OrderByDescending(x => x.Length)
                .First();                
 
            Console.WriteLine(longestString);
        }
    }
}

using System;
using System.Text;

namespace StringBuilderSubstring
{
    class SubstringTest
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("StringBuilder Substring Test");
            var test = sb.Substring(0, 3);
            Console.WriteLine(test);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace ExtractInBrackets
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            var indices = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char current = expression[i];
                if (current == '(')
                {
                    indices.Push(i);
                   
                }
                else if (current == ')')
                {
                    var matchingIndex=indices.Pop();
                    Console.WriteLine(expression.Substring(matchingIndex,i-matchingIndex+1));
                }
            }
        }
    }
}

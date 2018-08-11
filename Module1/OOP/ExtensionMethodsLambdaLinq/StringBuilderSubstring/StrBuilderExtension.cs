using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilderSubstring
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int len)
        {
            StringBuilder result = new StringBuilder();
            for (int i = startIndex; i < len; i++)
            {
                result.Append(input[i]);
            }
            return result;
        }
    }
}

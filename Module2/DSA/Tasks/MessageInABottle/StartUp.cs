using System;
using System.Collections.Generic;
using System.Text;

namespace MessageInABottle
{
    class StartUp
    {
        static Dictionary<char, string> cypherDictionary;
        static string code;
        static int count = 0;
        static List<string> result = new List<string>();

        static void Main()
        {
            code = Console.ReadLine();
            string cypher = Console.ReadLine();
            cypherDictionary = new Dictionary<char, string>();

            StringBuilder keys = new StringBuilder();

            for (int i = 0; i < cypher.Length; i++)
            {
                if (char.IsLetter(cypher[i]))
                {
                    keys.Append(cypher[i]);
                }
            }
            for (int i = 0; i <= keys.Length - 1; i++)
            {
                if (i == keys.Length - 1)
                {
                    cypherDictionary.Add(keys[i], cypher.Substring(cypher.IndexOf(keys[i]) + 1));
                    break;
                }
                var startIndex = cypher.IndexOf(keys[i]);
                var endIndex = cypher.IndexOf(keys[i + 1]);
                var value = cypher.Substring(startIndex + 1, endIndex - startIndex - 1);
                cypherDictionary.Add(keys[i], value);
            }
            Solve(0, new StringBuilder());
            result.Sort();

            Console.WriteLine(result.Count);
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join("\n", result));
            }
        }
        static void Solve(int codeIndex, StringBuilder sb)
        {
            if (codeIndex == code.Length)
            {
                count++;
                result.Add(sb.ToString());

                return;
            }
            foreach (var item in cypherDictionary)
            {
                if (code.Substring(codeIndex).StartsWith(item.Value))
                {
                    sb.Append(item.Key);
                    Solve(codeIndex + item.Value.Length, sb);
                    sb.Length--;
                }
            }
        }
    }
}

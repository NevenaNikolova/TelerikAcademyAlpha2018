using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordOccurences
{
    class Program
    {
        private static readonly string text =
            "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
        static void Main()
        {
            string[] words = text.ToLower().Split(new char[] 
            { '.', ',', '!', ' ', '/', '-', ':', ';', '?', '"', '\'', '&', '–'}, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                int count;
                if (!occurences.TryGetValue(word, out count))
                {
                    count = 0;
                }
                occurences[word] = count + 1;
            }

            var result = occurences.OrderBy(x => x.Value);
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}",item.Key, item.Value);
            }

        }
    }
}

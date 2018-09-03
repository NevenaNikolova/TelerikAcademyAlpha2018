using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.Spell_Caster
{
    class Program
    {
        static void Main()
        {
            string[] sentence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string extractedSentence = ExtractingCharacters(sentence);
            MovingTheCharacters(extractedSentence);
            //Console.WriteLine(extractedSentence);
        }

        static void MovingTheCharacters(string sentence)
        {            
            StringBuilder result = new StringBuilder();
            result.Append(sentence);

            for (int i = 0; i < sentence.Length; i++)
            {
                char currentChar = sentence[i];
                int newIndex = char.ToLower(sentence[i]) - 'a' + 1;
                int startPos = i + 1;

                while (newIndex > sentence.Length)
                {
                    newIndex %= sentence.Length;
                }

                int newPos = startPos + newIndex;

                if (newPos > sentence.Length)
                {
                    newPos %= sentence.Length;
                    newPos -= 1;
                    result.Insert(newPos, currentChar);
                    result.Remove(i + 1, 1);
                    sentence = result.ToString();
                }
                else
                {
                    result.Insert(newPos, currentChar);
                    result.Remove(i, 1);
                    sentence = result.ToString();
                }

            }
            Console.WriteLine(result.ToString());
        }

        static string ExtractingCharacters(string[] sentence)
        {
            string result = "";
            int bestLen = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                int currentLen = sentence[i].Length;
                if (currentLen > bestLen)
                {
                    bestLen = currentLen;
                }
            }

            for (int i = 0; i < bestLen; i++)
            {
                for (int j = 0; j < sentence.Length; j++)
                {
                    string currentWord = sentence[j];
                    if (currentWord != string.Empty)
                    {
                        int lastCharInd = currentWord.Length - 1;
                        string lastChar = currentWord.Substring(lastCharInd, 1);
                        result += lastChar;
                        sentence[j] = sentence[j].Remove(lastCharInd, 1);
                    }
                }
            }
            return result;
        }
    }
}

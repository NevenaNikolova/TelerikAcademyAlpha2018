using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string text = Console.ReadLine().ToLower();
            long result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    result += text[i] - 'a';
                }
                else if (char.IsDigit(text[i]))
                {
                    result *= text[i] - '0';
                }
                else if (text[i] == '@')
                {
                    //Console.WriteLine(result);
                    break;
                }
                else
                {
                    result %= m;
                }
            }
            Console.WriteLine(result);
        }
    }
}

using System;

namespace Passwords
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string signs = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            char[] password = new char[n];
            PrintPasswordK(password, 0, signs, k);
            Console.WriteLine(string.Join("", password));

        }
        static int PrintPasswordK(char[] pass, int index, string signs, int k)
        {

            if (index == 0)
            {

                for (char i = '0'; i <= '9'; i++)
                {
                    pass[0] = i;
                    k = PrintPasswordK(pass, 1, signs, k);
                    if (k <= 0)
                    {
                        return k;
                    }
                }
                return k;
            }

            if (index - 1 >= signs.Length)
            {
                return k - 1;
            }
            if (signs[index - 1] == '=')
            {
                pass[index] = pass[index - 1];
                k = PrintPasswordK(pass, index + 1, signs, k);
                if (k <= 0)
                {
                    return k;
                }
            }
            else if (signs[index - 1] == '<')
            {
                char lastChar = pass[index - 1] == '0' ? '9' : (char)(pass[index - 1] - 1);

                for (char i = '1'; i <= lastChar; i++)
                {
                    pass[index] = i;
                    k = PrintPasswordK(pass, index + 1, signs, k);
                    if (k <= 0)
                    {
                        return k;
                    }
                }
            }
            else if (pass[index - 1] != '0')
            {
                pass[index] = '0';

                k = PrintPasswordK(pass, index + 1, signs, k);
                if (k <= 0)
                {
                    return k;
                }

                for (char i = (char)(pass[index - 1] + 1); i <= '9'; i++)
                {
                    pass[index] = i;
                    k = PrintPasswordK(pass, index + 1, signs, k);
                    if (k <= 0)
                    {
                        return k;
                    }

                }
            }
            return k;
        }
    }
}

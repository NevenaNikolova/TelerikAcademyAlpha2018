using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalFromSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder();
            message.Append(Console.ReadLine());

            for (int i = 0; i < message.Length-1; i++)
            {
                if (message[i] == message[i + 1])
                {
                    while (i<message.Length-1 && message[i] == message[i + 1])
                    {
                        message.Remove(i, 1);
                    }             
                }
            }
            Console.WriteLine(message.ToString());
        }
    }
}

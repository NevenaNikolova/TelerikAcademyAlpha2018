using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    sum += number[i] - '0';
                }
            }
            number = sum.ToString();
            int sumedSum = 0;
           if (sum > 9)
           {           
               while (sum > 0)
               {
                   sumedSum += sum % 10;
                   sum /= 10;                  
               }
                number = sumedSum.ToString();
           }
            if (sumedSum > 9)
            {
                int sumedSumedSum = 0;
                while (sumedSum > 0)
                {
                    sumedSumedSum += sumedSum % 10;
                    sumedSum /= 10;
                }
                number = sumedSumedSum.ToString();
            }
            Console.WriteLine(number);
        }
    }
}

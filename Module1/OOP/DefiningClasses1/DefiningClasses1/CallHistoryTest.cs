using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice
{
    public class CallHistoryTest
    {
        private GSM lastGSM= new GSM("Samsung 5", "Samsung");
        public const decimal pricePerMin = 0.37m;

        public void TestCallHistory()
        {
            var a = new Call(new DateTime(2018, 07, 21, 10, 54, 6), new DateTime(2018, 07, 21, 10, 54, 6), "0888 265 897", 55);
            lastGSM.AddCall(a);
            var b = new Call(new DateTime(2018, 07, 21, 12, 35, 9), new DateTime(2018, 07, 21, 12, 35, 9), "0887 355 887", 60);
            lastGSM.AddCall(b);
            var c = new Call(new DateTime(2018, 07, 21, 13, 38, 10), new DateTime(2018, 07, 21, 13, 38, 10), "0879 548 486", 30);
            lastGSM.AddCall(c);

            Console.WriteLine(lastGSM.CallHistoryInfo());
            Console.WriteLine("Total Price: {0:C2}", lastGSM.CalculatePrice(pricePerMin));

            var longestCall = lastGSM.CallHistory.OrderByDescending(x => x.Duration).First();
            lastGSM.RemoveCall(longestCall);

            Console.WriteLine("Price after deleting the longest call: {0:C2}", lastGSM.CalculatePrice(pricePerMin));

            lastGSM.ClearHistory();

            Console.WriteLine(lastGSM.CallHistoryInfo());
                
        }
    }
}

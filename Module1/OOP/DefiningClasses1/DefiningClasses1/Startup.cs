using System;

namespace MobileDevice
{
    class Startup
    {
        static void Main()
        {
            //var gsmTest = new GSMTest();
            //gsmTest.DisplayInfo();

            var callHistoryTest = new CallHistoryTest();
            callHistoryTest.TestCallHistory();
        }
    }
}

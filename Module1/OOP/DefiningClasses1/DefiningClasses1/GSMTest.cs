using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevice
{
    public class GSMTest
    {
        private GSM[] gsmArray;
        
        public GSMTest()
        {
            this.gsmArray = new GSM[5]
            {
            new GSM("Nokia20", "Nokia"),
            new GSM("IPhone5", "Apple", 1300),
            new GSM("HTC 4", "HTC", 800, "Joro"),
            new GSM("Sony3", "Sony", 700, "Penka", new Battery("Li")),
            new GSM("Samsung S5", "Samsung", 900, "Gosho", new Battery(BatteryType.LiIon), new Display(50.5, 100))
            };
        }

        public void DisplayInfo()
        {
            foreach (var item in gsmArray)
            {
                item.PrintInfo();
            }
            GSM.IPhone4.PrintInfo();
        }
    }
}

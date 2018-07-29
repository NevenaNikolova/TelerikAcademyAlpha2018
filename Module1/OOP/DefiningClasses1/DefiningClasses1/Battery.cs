using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevice
{
    
    public class Battery
    {
        private string model;
        private TimeSpan hoursIdle;
        private TimeSpan hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {

        }
        public Battery(string model)
        {
            this.Model = model;
        }
        public Battery(BatteryType batteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, TimeSpan hoursIdle, TimeSpan hoursTalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
        public string Model
        {
            get { return this.model; }
            set
            {               
                this.model = value;
            }
        }
        public TimeSpan HoursIdle { get; set; }
        public TimeSpan HoursTalk { get; set; }
        public BatteryType BatteryType { get; set; }

        public override string ToString()
        {
            return $"\nBattery Model: {this.model}\nBatteryType: {this.batteryType}";
        }

    }
}

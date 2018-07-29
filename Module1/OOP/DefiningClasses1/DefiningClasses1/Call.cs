using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevice
{
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string number;
        private int duration;

        public Call(DateTime date, DateTime time, string number, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.Number = number;
            this.Duration = duration;
        }
        public DateTime Date
        {
            get { return this.date;}
            set { this.date = value; }
        }
        public DateTime Time
        {
            get { return this.time;}
            set { this.time = value; }
        }
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            return string.Format("Date: {0:dd/MM/yy}\nTime: {1: H:mm:ss}\nNumber: {2}\nDuration: {3}\n", 
                this.Date,this.Time, this.Number, this.Duration);
        }
    }
}

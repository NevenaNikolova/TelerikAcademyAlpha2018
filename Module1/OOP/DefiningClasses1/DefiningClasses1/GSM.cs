using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevice
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        private static GSM iPhone4 = new GSM("IPhone4", "Apple");

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;          
        }
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }
        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;          
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.Display = display;
        }       

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value)|| string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The sum must be positive!");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {              
                if (value.Length < 2)
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
       public static GSM IPhone4
        {
            get { return GSM.iPhone4;}
        }
        
        public override string ToString()
        {
            return string.Format
               ("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery---{4}\nDisplay---{5}",
               this.Model, this.Manufacturer, this.Price, this.Owner,this.Battery,this.Display);
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.ToString());
        }
        public string CallHistoryInfo()
        {
            StringBuilder info = new StringBuilder();

            foreach (var call in callHistory)
            {
                info.Append(call.ToString());
            }
            return info.ToString();
        }
        public void AddCall(Call nextCall)
        {
            this.callHistory.Add(nextCall);
        }
        public void RemoveCall(Call nextCall)
        {
            this.callHistory.Remove(nextCall);
        }
        public void ClearHistory()
        {
            this.callHistory.Clear();
        }
        public decimal CalculatePrice(decimal pricePerMin)
        {            
            int totalSec = 0;
            foreach (var call in callHistory)
            {
                totalSec += call.Duration;
            }
            decimal price = totalSec * (pricePerMin / 60);

            return Math.Round(price, 2);
        
        }
    }
}

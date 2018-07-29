using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevice
{
    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display()
        {

        }
        public Display(double size,int numberOfColors)
        {
            this.Size = size;
            this.NumberOfcolors = numberOfColors;
        }

        public double Size
        {
            get { return this.size; }
            set
            {              
                this.size = value;
            }
        }
        public int NumberOfcolors
        {
            get { return this.numberOfColors;}
            set
            {
                //if (value < 0)
                //{
                //    throw new ArgumentOutOfRangeException("The number of colors must be a positive number!");
                //}
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return $"\nDisplay Size: {this.size}\nDisplay Colors: {this.numberOfColors}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    public class Student : Person, ICommentable
    {
        private int number;
   
        public Student(string name):base(name)
        {
            this.Number = number;
        }
        public int Number
        {
            get { return this.number; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.number = value;
            }
        }

        public void Comment(string message)
        {
            Console.WriteLine(message);
        }
        public override string ToString()
        {
            return string.Format("Student {0} with class number {1}.\n", this.Name, this.Number);
        }
    }
}

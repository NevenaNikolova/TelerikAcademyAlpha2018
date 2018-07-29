using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    public class Discipline:ICommentable
    {
        private string name;
        private int lectures;
        private int excercises;

        public Discipline(string name, int excercises, int lectures)
        {
            this.Name = name;
            this.Excercises = excercises;
            this.Lectures = lectures;
        }
        public int Excercises
        {
            get { return this.excercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.excercises = value;
            }
        }
        public int Lectures
        {
            get { return this.lectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.lectures = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public void Comment(string message)
        {
            Console.WriteLine(message);
        }

        public override string ToString()
        {
            return string.Format("discipline {0} has {1} lectures and {2} excercises per week.", this.Name, this.Lectures, this.Excercises);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    public class Teacher : Person,ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.disciplines = new List<Discipline>();

            foreach (var descipline in disciplines)
            {
                this.disciplines.Add(descipline);
            }
        }
        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(this.disciplines); }
        }

        public void Comment(string message)
        {
            Console.WriteLine(message);
        }

        public override string ToString()
        {
            return string.Format("Teacher {0} can teach {1}", this.Name, string.Join(", ", this.Disciplines));
        }
    }
}
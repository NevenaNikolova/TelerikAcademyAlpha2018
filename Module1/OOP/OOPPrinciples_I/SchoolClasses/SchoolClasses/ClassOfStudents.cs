using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    public class ClassOfStudents : ICommentable
    {
        private List<Teacher> teachers;
        private string textIdentifier;

        public ClassOfStudents(string textIdentifier ,List<Teacher> teachers)
        {
            this.TextIdentifier = textIdentifier;
            this.teachers = new List<Teacher>();
            foreach (var t in teachers)
            {
                this.teachers.Add(t);
            }
        }
        public List<Teacher> Teachers
        {
            get { return new List<Teacher>(this.teachers); }
        }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.textIdentifier = value;
            }
        }

        public void Comment(string message)
        {
            Console.WriteLine(message);
        }

        public override string ToString()
        {
            return string.Format("Class with text identifier {0} and teachers: {1}.\n", this.textIdentifier, string.Join(" ", this.Teachers));
        }
    }
}

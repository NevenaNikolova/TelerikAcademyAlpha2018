using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            return string.Format("Student: {0} {1} with grade: {2}\n", this.FirstName, this.LastName, this.Grade);
        }
    }
}

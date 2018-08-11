using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsTasks
{
    public class Student
    {
        private List<double> marks;


        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, int age, int fNumber, string phone, string email, List<double> marks, int groupNumber)
            : this(firstName, lastName, age)
        {
            this.FNumber = fNumber;
            this.Phone = phone;
            this.Email = email;
            this.marks = new List<double>();
            foreach (var item in marks)
            {
                this.marks.Add(item);
            }
            this.GroupNumber = groupNumber;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<double> Marks
        {
            get
            {
                return new List<double>(this.marks);
            }
            set
            {             
                this.marks = value;
            }
        }

        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", 
                this.FirstName, this.LastName, this.Age, this.FNumber, this.Phone, this.Email, string.Join(" ", this.Marks));
        }
    }
}

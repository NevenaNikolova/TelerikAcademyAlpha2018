using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private GenderType gender;

        public Animal(int age, string name, GenderType gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public GenderType Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public abstract void Sound();

        public override string ToString()
        {
            return string.Format("{0} is {1} and is {2} years old.", this.Name, this.Gender, this.Age);
        }

    }
}

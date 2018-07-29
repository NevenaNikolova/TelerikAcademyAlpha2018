using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(int age, string name, GenderType gender) :base(age,name,gender)
        {
            
        }
        public override void Sound()
        {
            Console.WriteLine("Wow wow!");
        }

        public override string ToString()
        {
            return string.Format("Dog {0} is {1} and is {2} years old.", this.Name, this.Gender, this.Age);
        }
    }
}

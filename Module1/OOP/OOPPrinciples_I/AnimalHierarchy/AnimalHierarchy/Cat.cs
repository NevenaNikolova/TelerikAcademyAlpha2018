using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(int age, string name, GenderType gender) :base(age, name, gender)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("Miau Miau!");
        }
    }
}

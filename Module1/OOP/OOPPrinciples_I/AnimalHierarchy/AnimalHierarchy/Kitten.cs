using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name) : base(age, name, GenderType.female)
        {
        }
    }
}

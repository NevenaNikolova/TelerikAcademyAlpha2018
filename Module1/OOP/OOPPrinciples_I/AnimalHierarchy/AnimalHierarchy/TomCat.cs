using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public class TomCat : Cat
    {
        public TomCat(int age, string name) : base(age, name, GenderType.male)
        {
        }
    }
}

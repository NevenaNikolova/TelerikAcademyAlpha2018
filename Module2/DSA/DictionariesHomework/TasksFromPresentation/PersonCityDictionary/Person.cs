using System;
using System.Collections.Generic;
using System.Text;

namespace PersonCityDictionary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //public override bool Equals(object obj)
        //{
        //    var other = obj as Person;
        //    if (other == null)
        //    {
        //        return false;
        //    }
        //    return this.FirstName == other.FirstName
        //        && this.LastName == other.LastName;
        //}

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(FirstName, LastName);
        //}
    }
}

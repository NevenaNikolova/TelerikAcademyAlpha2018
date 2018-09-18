using System;
using System.Collections.Generic;
using System.Text;

namespace PersonCityDictionary
{
   public class City:IComparable<City>
    {
        public string Name { get; set; }
        public string CountryName { get; set; }
        public string PostalCode { get; set; }

        public City(string name, string countryName, string postalCode)
        {
            Name = name;
            CountryName = countryName;
            PostalCode = postalCode;
        }

        public override bool Equals(object obj)
        {
            var other = obj as City;
            if (other == null)
            {
                return false;
            }
            return this.Name == other.Name
                && this.CountryName == other.CountryName
                && this.PostalCode == other.PostalCode;
        }

        public override string ToString()
        {
            return Name + " " + CountryName + " " + PostalCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, CountryName, PostalCode);
        }

        public int CompareTo(City other)
        {
            int nameComparison = this.Name.CompareTo(other.Name);
            if (nameComparison == 0)
            {
                return this.CountryName.CompareTo(other.CountryName);
            }
            return nameComparison;
        }
    }
}

using System;
using System.Collections.Generic;

namespace PersonCityDictionary
{
    class Program
    {
        static void Main()
        {
            IDictionary<City, List<Person>> sortedDict =
                new SortedDictionary<City, List<Person>>();
            //IDictionary<City, List<Person>> dict = new Dictionary<City, List<Person>>();
            var sofia = new City("Sofia", "Bulgaria", "1000");
            var varna = new City("Varna", "Bulgaria", "1500");
            var burgas = new City("Burgas", "Bulgaria", "1004");

            var peopleSofia = new List<Person>()
            {
                new Person("Gosho", "Goshov"),
                new Person("Pesho", "Peshov")
            };
            var peopleVarna = new List<Person>()
            {
                new Person("Goshka", "Goshova"),
                new Person("Peshka", "Peshova")
            };
            var peopleBurgas = new List<Person>()
            {
                new Person("Ivan", "Ivanov"),
                new Person("Dragan", "Petrov")
            };

            //dict.Add(sofia, peopleSofia);
            //dict.Add(varna, peopleVarna);
            //dict.Add(burgas, peopleBurgas);

            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Key);               
            //    Console.WriteLine(string.Join(", ", item.Value));
            //    Console.WriteLine();
            //}
            sortedDict.Add(sofia, peopleSofia);
            sortedDict.Add(varna, peopleVarna);
            sortedDict.Add(burgas, peopleBurgas);

            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
            }           
        }
    }
}

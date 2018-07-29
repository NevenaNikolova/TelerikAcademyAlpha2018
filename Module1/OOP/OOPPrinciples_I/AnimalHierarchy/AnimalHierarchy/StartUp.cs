using System;
using System.Collections.Generic;

namespace AnimalHierarchy
{
    class StartUp
    {
        static void Main()
        {
            var animals = new List<Animal>()
            {
                new Dog(1, "Pesho", GenderType.male),
                new Cat(2, "Goshka", GenderType.female),
                new Cat(2, "Misho", GenderType.male),
                new TomCat(5, "Tom"),
                new Kitten(4, "Kitty"),
                new Dog(3, "Charlie", GenderType.male),
                new Frog(1, "Penka", GenderType.female)
            };

            Console.WriteLine(string.Join(" ", animals));
            Console.WriteLine("{0:F2}", AverageAge.CalculateAverageAge(animals));
            
        }
    }
}

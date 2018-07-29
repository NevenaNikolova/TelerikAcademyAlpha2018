using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    class StartUp
    {
        static void Main()
        {          
            var disc1 = new List<Discipline>
            {
                new Discipline("Math", 5,6),
                new Discipline ("Phisics", 3,2)
            };
            Teacher ivan = new Teacher("Ivan Ivanov", disc1);

            var disc2 = new List<Discipline>
            {
                new Discipline("Literature", 2,6),
                new Discipline("Geography",4,6)
            };

            Teacher pesho = new Teacher("Pesho", disc2);
            Console.WriteLine(ivan);

            var teachers = new List<Teacher> { ivan, pesho };

            var stClass = new ClassOfStudents("7B", teachers);
            Console.WriteLine(stClass);
           
        }
    }
}

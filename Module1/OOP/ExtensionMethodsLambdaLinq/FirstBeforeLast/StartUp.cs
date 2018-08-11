using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsTasks
{
    class StartUp
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Petrov", 18, 5456, "02125458", "jhga@abv.bg", new List<double>(){6.0,3.5,4.0},2),
                new Student("Pesho", "Georgiev",19, 486, "0245123484", "uash@abv.bg", new List<double>(){5.0,4.5,2.0},2),
                new Student("Gosho", "Ivanov",20, 4658,"0887562862", "jgas@mail.bg", new List<double>(){3.0,4.5,5.5},1),
                new Student("Dragan", "Jordanov",17, 542,"0889157358", "fhs@mail.bg", new List<double>(){2.0,2.0,3.5},1),
                new Student("Penka", "Menka",16, 1256, "0885125438", "liga@abv.bg", new List<double>(){6.0,3.5,4.0},1),
                new Student("Baba", "Meca",25,  8676, "0885258458", "uja@abv.bg", new List<double>(){5.0,3.5,4.0},2)
            };

            var firstBeforeLast = students
                .Where(x => x.FirstName.CompareTo(x.LastName) < 0)
                .Select(x => x.FirstName + " " + x.LastName);

            var age18To24 = students
                .Where(x => x.Age >= 18 && x.Age <= 24)
                .Select(x => x.FirstName + " " + x.LastName);

            var orderByName = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .Select(x => x.FirstName + " " + x.LastName);

            //Console.WriteLine(string.Join("\n", firstBeforeLast.ToList()));

            //Console.WriteLine(string.Join("\n", age18To24.ToList()));

            //Console.WriteLine(string.Join("\n", orderByName.ToList()));

            var group2 = students
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x=>x.FirstName)
                .Select(x => x.FirstName + " " + x.LastName);

            //Console.WriteLine(string.Join("\n", group2.ToList()));

            var abvEmail = students
                .Where(x => x.Email.Contains("abv.bg"));

            // Console.WriteLine(string.Join("\n", abvEmail.ToList()));

            var phoneStartsWith02 = students
                .Where(x => x.Phone.StartsWith("02"));

            //Console.WriteLine(string.Join("\n", phoneStartsWith02.ToList()));

            var studentsWith6Mark = students
                .Where(x => x.Marks.Contains(6.0))
                .Select(x => x.FirstName + " " + x.LastName + " " + string.Join(" ", x.Marks));

            //Console.WriteLine(string.Join("\n", studentsWith6Mark.ToList()));

            var studentsWith2Marks2 = students
                .Where(x => x.Marks.FindAll(m => m == 2.0).Count == 2);

            Console.WriteLine(string.Join("\n", studentsWith2Marks2.ToList()));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 6.00),
                new Student("Gosho", "Goshev", 3.50),
                new Student("Pesho", "Peshov", 4.80),
                new Student("Petar", "Petrov", 5.00),
                new Student("Penka", "Penkova", 4.00)
            };

            //var sortedStudents = students.OrderBy(x => x.Grade).ToList();
            //Console.WriteLine(string.Join(" ", sortedStudents));

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Dancho", "Danchev", 180, 8),
                new Worker("Stoqn", "Ivanov", 200, 8),
                new Worker("Mincho", "Milchev", 100, 4),
                new Worker("Kostadin", "Kirilov", 180, 8),
                new Worker("Ivailo", "Iordanov", 250, 8),
                new Worker("Petko", "Krustev", 140, 6),
                new Worker("Kaloqn", "Monev", 160, 8),
                new Worker("Atanas", "Dimitrov", 190, 8),
                new Worker("Stilqn", "Stoilov", 170, 9),
                new Worker("Mitko", "Andonov", 300, 8)
            };

            //var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
            //Console.WriteLine(string.Join(" ", sortedWorkers));

            var studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            var mergedAndSorted = studentsAndWorkers
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();
            Console.WriteLine(string.Join(" ", mergedAndSorted));
        }
    }
}

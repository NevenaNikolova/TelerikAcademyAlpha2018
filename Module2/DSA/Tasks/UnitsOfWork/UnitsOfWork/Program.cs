using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UnitsOfWork
{
    class Program
    {
        static Dictionary<string, Unit> unitsDict = new Dictionary<string, Unit>();
        static Dictionary<string, SortedSet<Unit>> findByType = new Dictionary<string, SortedSet<Unit>>();
        static SortedSet<Unit> findByPower = new SortedSet<Unit>();

        static void Main()
        {
            StringBuilder builder = new StringBuilder();
            string line;

            while ((line = Console.ReadLine()) != "end")
            {
                var args = line.Split();
                string message = string.Empty;
                switch (args[0])
                {
                    case "add":
                        var attack = int.Parse(args[3]);
                        message = AddUnit(args[1], args[2], attack);
                        break;
                    case "remove":
                        message = RemoveUnit(args[1]);
                        break;
                    case "find":
                        message = FindByType(args[1]);
                        break;
                    case "power":
                        message = FindMostPowerful(int.Parse(args[1]));
                        break;
                    default:
                        break;
                }
                builder.AppendLine(message);
            }
            Console.WriteLine(builder.ToString().TrimEnd());
        }
        static string AddUnit(string name, string type, int attack)
        {
            if (unitsDict.ContainsKey(name))
            {
                return $"FAIL: {name} already exists!";
            }
            var newUnit = new Unit(name, type, attack);
            unitsDict.Add(name, newUnit);

            if (!findByType.ContainsKey(type))
            {
                findByType[type] = new SortedSet<Unit>();
            }
            findByType[type].Add(newUnit);
            findByPower.Add(newUnit);

            return $"SUCCESS: {name} added!";
        }
        static string RemoveUnit(string name)
        {
            if (!unitsDict.ContainsKey(name))
            {
                return $"FAIL: {name} could not be found!";
            }
            var unit = unitsDict[name];
            unitsDict.Remove(unit.Name);
            findByPower.Remove(unit);
            findByType[unit.Type].Remove(unit);
           
            return $"SUCCESS: {name} removed!";
        }
        static string FindByType(string type)
        {
            if (!findByType.ContainsKey(type))
            {
                return $"RESULT: ";
            }
            return "RESULT: " + string.Join(", ", findByType[type].Take(10));
        }
        static string FindMostPowerful(int number)
        {
            if (number > findByPower.Count)
            {
                return "RESULT: " + string.Join(", ", findByPower);
            }
            else
            {
                return "RESULT: " + string.Join(", ", findByPower.Take(number));
            }

        }
    }
    public class Unit : IComparable<Unit>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Attack { get; set; }

        public Unit(string name, string type, int attack)
        {
            Name = name;
            Type = type;
            Attack = attack;
        }

        public int CompareTo(Unit other)
        {
            int comparisson = -this.Attack.CompareTo(other.Attack);
            if (comparisson == 0)
            {
                comparisson = this.Name.CompareTo(other.Name);
            }
            return comparisson;
        }
        public override string ToString()
        {
            return $"{Name}[{Type}]({Attack})";
        }
    }
}

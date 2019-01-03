using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    class Program
    {
        static BigList<Player> playerRankList = new BigList<Player>();
        static Dictionary<string, OrderedSet<Player>> playersByType = new Dictionary<string, OrderedSet<Player>>();
        static StringBuilder builder = new StringBuilder();

        static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != "end")
            {
                var args = line.Split();
                string message = string.Empty;
                switch (args[0])
                {
                    case "add":
                        var age = int.Parse(args[3]);
                        var position = int.Parse(args[4]);
                        message = AddPlayer(args[1], args[2], age, position);
                        break;
                    case "find":
                        message = FindByType(args[1]);
                        break;
                    case "ranklist":
                        int start = int.Parse(args[1]);
                        int end = int.Parse(args[2]);
                        message = ShowRankList(start, end);
                        break;
                    default:
                        break;
                }
                builder.AppendLine(message);
            }
            Console.WriteLine(builder.ToString().TrimEnd());
        }

        static string ShowRankList(int start, int end)
        {
            int count = end - start + 1;
            var ranked = playerRankList.Range(start - 1, count);
            StringBuilder b = new StringBuilder();

            int playerPos = start;
            foreach (var item in ranked)
            {
                b.AppendFormat("{0}. {1}; ", playerPos++, item);
            }
            b.Length -= 2;
            //for (int i = start - 1; i < end - 1; i++)
            //{
            //    b.AppendFormat("{0}. {1}; ", start++, ranked[i]);
            //}
            //b.AppendFormat("{0}. {1}", end, ranked[end - 1]);
            return b.ToString();
        }

        static string FindByType(string type)
        {
            if (!playersByType.ContainsKey(type))
            {
                return $"Type {type}: ";
            }
            return $"Type {type}: " + string.Join("; ", playersByType[type].Take(5));
        }

        static string AddPlayer(string name, string type, int age, int position)
        {
            var playerToAdd = new Player(name, type, age, position);

            if (playersByType.ContainsKey(type))
            {
                playersByType[type].Add(playerToAdd);
            }
            else
            {
                playersByType[type] = new OrderedSet<Player>();
                playersByType[type].Add(playerToAdd);
            }
            if (position > playerRankList.Count)
            {
                playerRankList.Add(playerToAdd);
            }
            else
            {
                playerRankList.Insert(position - 1, playerToAdd);
            }
            return $"Added player {name} to position {position}";
        }
        public class Player : IComparable<Player>
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int Age { get; set; }
            public int Position { get; set; }

            public Player(string name, string type, int age, int position)
            {
                Name = name;
                Type = type;
                Age = age;
                Position = position;
            }

            public int CompareTo(Player other)
            {
                var comparisson = this.Name.CompareTo(other.Name);
                if (comparisson == 0)
                {
                    comparisson = this.Age.CompareTo(other.Age)*-1;
                }
                return comparisson;
            }

            public override string ToString()
            {
                return $"{Name}({Age})";
            }
        }
    }
}

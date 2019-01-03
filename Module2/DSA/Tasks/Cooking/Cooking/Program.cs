using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace Problem_3_Cooking
{
    public class Program
    {
        public static Dictionary<string, KeyValuePair<decimal, string>> recipe =
             new Dictionary<string, KeyValuePair<decimal, string>>(StringComparer.InvariantCultureIgnoreCase);
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //Recipe
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine().Split(':');
                decimal quantity = decimal.Parse(product[0]);
                string measure = product[1];
                string name = product[2];

                if (!recipe.ContainsKey(name))
                {
                    recipe.Add(name, new KeyValuePair<decimal, string>(quantity, measure));
                }
                else
                {
                    KeyValuePair<decimal, string> currentPair;
                    recipe.TryGetValue(name, out currentPair);
                    var measureTo = currentPair.Value;
                    var newQuantity = currentPair.Key;

                    if (measure == measureTo)
                    {
                        newQuantity += quantity;
                    }
                    else
                    {
                        var convertToCups = Units.ConvertToCups(quantity, measure);
                        var convertFromCups = Units.ConvertFromCups(convertToCups, measureTo);
                        newQuantity += convertFromCups;
                    }
                    recipe[name] = new KeyValuePair<decimal, string>(newQuantity, measureTo);
                }
            }
            //Krisi`s products
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var usedProduct = Console.ReadLine().Split(':');
                decimal quantity = decimal.Parse(usedProduct[0]);
                string measure = usedProduct[1];
                string name = usedProduct[2];

                if (recipe.ContainsKey(name))
                {
                    KeyValuePair<decimal, string> pair;
                    recipe.TryGetValue(name, out pair);
                    decimal currentQnty = pair.Key;
                    string measureTo = pair.Value;

                    if (measure == measureTo)
                    {
                        currentQnty -= quantity;
                    }
                    else
                    {
                        var convertToCups = Units.ConvertToCups(quantity, measure);
                        var convertFromCups = Units.ConvertFromCups(convertToCups, measureTo);
                        currentQnty -= convertFromCups;
                    }
                    if (currentQnty <= 0)
                    {
                        recipe.Remove(name);
                    }
                    else
                    {
                        recipe[name] = new KeyValuePair<decimal, string>(currentQnty, measureTo);
                    }
                }
            }
            foreach (var item in recipe)
            {
                var qnty = item.Value.Key;
                var msr = item.Value.Value;
                var pr = item.Key;
                Console.WriteLine("{0:F2}:{1}:{2}", qnty, msr, pr);
            }
        }
    }
    static class Units
    {
        static readonly List<Tuple<string, decimal>> converterToCups = new List<Tuple<string, decimal>>();
        static Units()
        {
            converterToCups.Add(new Tuple<string, decimal>("tablespoons", 1.0M / 16.0M));
            converterToCups.Add(new Tuple<string, decimal>("tbsps", 1.0M / 16.0M));
            converterToCups.Add(new Tuple<string, decimal>("teaspoons", 1.0M / 48.0M));
            converterToCups.Add(new Tuple<string, decimal>("tsps", 1.0M / 48.0M));
            converterToCups.Add(new Tuple<string, decimal>("milliliters", 1.0M / 240.0M));
            converterToCups.Add(new Tuple<string, decimal>("mls", 1.0M / 240.0M));
            converterToCups.Add(new Tuple<string, decimal>("liters", 25.0M / 6.0M));
            converterToCups.Add(new Tuple<string, decimal>("ls", 25.0M / 6.0M));
            converterToCups.Add(new Tuple<string, decimal>("fluid ounces", 1.0M / 8.0M));
            converterToCups.Add(new Tuple<string, decimal>("fl ozs", 1.0M / 8.0M));
            converterToCups.Add(new Tuple<string, decimal>("pints", 2.0M));
            converterToCups.Add(new Tuple<string, decimal>("pts", 2.0M));
            converterToCups.Add(new Tuple<string, decimal>("quarts", 4.0M));
            converterToCups.Add(new Tuple<string, decimal>("qts", 4.0M));
            converterToCups.Add(new Tuple<string, decimal>("gallons", 16.0M));
            converterToCups.Add(new Tuple<string, decimal>("gals", 16.0M));
            converterToCups.Add(new Tuple<string, decimal>("cups", 1.0M));
        }

        public static decimal ConvertToCups(decimal Quanity, string fromUnit)
        {
            return converterToCups.First(x => x.Item1 == fromUnit).Item2 * Quanity;
        }

        public static decimal ConvertFromCups(decimal Quanity, string toUnit)
        {
            return Quanity / converterToCups.First(x => x.Item1 == toUnit).Item2;
        }
    }
}



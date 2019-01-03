using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GirlsGoneWild
{
    class Program
    {
        private static SortedSet<string> finalResult = new SortedSet<string>();
        private static int totalPeople;
        private static List<List<int>> combOfNumbers = new List<List<int>>();
        private static List<List<char>> combOfLetters = new List<List<char>>();

        static void Main()
        {
            var numbers = new int[int.Parse(Console.ReadLine())];
            var letters = Console.ReadLine().ToCharArray().OrderBy(c => c).ToArray();
            totalPeople = int.Parse(Console.ReadLine());

            Comb(numbers, 0, 0, comb =>
            {
                combOfNumbers.Add(new List<int>(comb));

            });
            numbers = new int[letters.Length];
            Comb(numbers, 0, 0, comb =>
            {
                var currentLetterComb = new List<char>();

                for (int i = 0; i < totalPeople; i++)
                {
                    currentLetterComb.Add(letters[comb[i]]);
                }
                combOfLetters.Add(currentLetterComb);
            });
            foreach (var numberComb in combOfNumbers)
            {
                foreach (var letterComb in combOfLetters)
                {
                    var newLetters = new List<char>(letterComb);
                    PermuteRep(newLetters, 0, newLetters.Count, perm =>
                    {
                        Merge(perm, numberComb);
                    });
                }
            }
            var result = new StringBuilder();
            result.AppendLine(finalResult.Count.ToString());
            foreach (var item in finalResult)
            {
                result.AppendLine(item);
            }

            Console.WriteLine(result.ToString().Trim());
        }
        public static void Merge(List<char> letters, List<int> numbers)
        {
            var result = new StringBuilder();
            for (int i = 0; i < letters.Count; i++)
            {
                result.Append(numbers[i]);
                result.Append(letters[i]);
                result.Append('-');
            }
            result.Length--;
            finalResult.Add(result.ToString().Trim('-'));
        }

        public static void Comb(int[] arr, int index, int start, Action<int[]> action)
        {
            if (index >= totalPeople)
            {
                action(arr);
            }
            else
            {
                for (int i = start; i < arr.Length; i++)
                {
                    arr[index] = i;
                    Comb(arr, index + 1, i + 1, action);
                }
            }
        }

        static void PermuteRep(List<char> arr, int start, int n, Action<List<char>> action)
        {
            action(arr);
            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        var oldValue = arr[left];
                        arr[left] = arr[right];
                        arr[right] = oldValue;

                        PermuteRep(arr, left + 1, n, action);
                    }
                    var firstElement = arr[left];
                    for (int i = left; i < n - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                        arr[n - 1] = firstElement;
                    }
                }
            }
        }

    }
}

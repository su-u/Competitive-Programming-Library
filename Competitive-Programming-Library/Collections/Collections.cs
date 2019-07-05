using System;
using System.Collections.Generic;
using System.Linq;
using CPL.Input;

namespace CPL.Collections
{
    static class CollectionsEx
    {
        public static List<Tuple<T, int>> DuplicateCount<T>(this IEnumerable<T> list)
        {
            return list
                .GroupBy(i => i)
                .Select(g => Tuple.Create(g.Key, g.Count()))
                .ToList();
        }

        public static List<Tuple<T, int>> DuplicateSort<T>(this IEnumerable<Tuple<T, int>> list)
        {
            return list.OrderByDescending(x => x.Item2).ToList();
        }

        public static List<T> ReadLineOne<T>(int n)
        {
            return Enumerable.Range(1, n).Select(i => Console.ReadLine().TryParse<T>()).ToList();
        }

        public static void PrintAll<T>(this IEnumerable<T> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CPL.Input
{
    public static class InputEx
    {
        public static T TryParse<T>(this string input)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                return (T)converter.ConvertFromString(input);
            }
            catch
            {
                throw new InvalidCastException(typeof(T) + " is not supported.");
            }
        }

        public static List<T> SplitTryParseToList<T>(this string input, char separator = ' ')
        {
            return input.Split(separator).Select(n => TryParse<T>(n)).ToList();
        }

        public static List<T> ListSwap<T>(this List<T> list, int index1, int index2)
        {
            var t = list[index1];
            list[index1] = list[index2];
            list[index2] = t;
            return list;
        }

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;
using CPL.Input;

namespace CPL
{
    static class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1,2,3,4};
            list.ListSwap(0, 1);

            list.PrintAll();


        }
        public static List<T> ListSwap<T>(this List<T> list, Int32 index1, Int32 index2)
        {
            var t = list[index1];
            list[index1] = list[index2];
            list[index2] = t;
            return list;
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

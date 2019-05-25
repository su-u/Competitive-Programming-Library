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
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().SplitTryParseToList<int>();
            Console.WriteLine(a.GetType());

        }


    }
}

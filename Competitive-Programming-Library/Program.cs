using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;
using CPL.Input;
using CPL.String;

namespace CPL
{
    class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<int>() { 1,2,3,4};
            list.ListSwap(0, 1);

            list.PrintAll();


        }
    }
}

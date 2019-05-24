using System;

namespace CPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            "1".ParseToInt32();

        }


    }

    static class Extensions
    {
        public static Int32 ParseToInt32(this string str)
        {
            return Int32.Parse(str);
        }

        public static Double ParseToDouble(this string str)
        {
            return Double.Parse(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CPL.Input
{
    static class Input
    {
        public static T TryParse<T>(this string input)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    return (T)converter.ConvertFromString(input);
                }
                else
                {
                    throw new InvalidCastException("");
                }
            }
            catch
            {
                throw new InvalidCastException(typeof(T) + " is not suported.");
            }
        }

        public static List<T> SplitTryParseToList<T>(this string input)
        {
            return input.Split().Select(n => n.TryParse<T>()).ToList();
        }

        public static List<T> Aa<Tsouse, T>(this Tsouse str)
        {
            List<T> list = new List<T>();
            return list;
        }

        public static Int32 ParseToInt32(this String str)
        {
            return Int32.Parse(str);
        }

        public static Double ParseToDouble(this String str)
        {
            return Double.Parse(str);
        }
    }
}

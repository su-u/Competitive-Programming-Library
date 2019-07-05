using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CPL
{
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
                return input.Split(separator).Select(TryParse<T>).ToList();
            }

            public static List<T> ListSwap<T>(this List<T> list, int index1, int index2)
            {
                var t = list[index1];
                list[index1] = list[index2];
                list[index2] = t;
                return list;
            }
        }
    }

}

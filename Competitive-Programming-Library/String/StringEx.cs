using System.Linq;

namespace CPL.String
{
    public static class StringEx
    {
        public static string Reversed(this string s)
        {
            return string.Join("", s.Reverse());
        }
    }
}

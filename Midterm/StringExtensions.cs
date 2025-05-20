using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public static class StringExtensions
    {
        public static string PadCenter(this string str, int length, char padChar = ' ')
        {
            int spaces = length - str.Length;
            int padLeft = spaces / 2 + str.Length;
            return str.PadLeft(padLeft, padChar).PadRight(length, padChar);
        }

        public static string Truncate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str)) return str;
            return str.Length <= maxLength ? str : str.Substring(0, maxLength - 3) + "...";
        }
    }
}

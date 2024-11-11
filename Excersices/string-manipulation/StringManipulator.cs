using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices.string_manipulation
{
    public static class StringManipulator
    {
        public static string InvertString(string initialStringValue)
        {
            if (string.IsNullOrWhiteSpace(initialStringValue))
            {
                Console.WriteLine($"Input : {initialStringValue} value is null.");
                return null;
            }

            char[] chars = initialStringValue.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public static string JoinStrings(string[] strings, string seperator)
        {
            if (strings == null)
                return null;

            return string.Join(seperator,strings);
        }
    }
}

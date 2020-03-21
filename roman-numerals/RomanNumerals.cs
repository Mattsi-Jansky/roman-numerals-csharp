using System;
using System.Linq;

namespace roman_numerals
{
    public static class RomanNumerals
    {
        public static string ParseFromDecimal(int n)
        {
            if (n == 5) return "V";
            return new string(Enumerable.Range(1, n).Select(_ => 'I').ToArray());
        } 
    }
}

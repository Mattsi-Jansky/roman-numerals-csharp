using System;
using System.Linq;

namespace roman_numerals
{
    public static class RomanNumerals
    {
        public static string ParseFromDecimal(int n)
        {
            return new string(Enumerable.Range(1, n).Select(_ => 'I').ToArray());
        } 
    }
}

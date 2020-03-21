using System;
using System.Collections.Generic;
using System.Linq;

namespace roman_numerals
{
    public static class RomanNumerals
    {
        private static readonly IDictionary<int, char> Numerals = new Dictionary<int, char>()
        {
            { 5, 'V'},
            { 10, 'X'}
        };
        
        public static string ParseFromDecimal(int n)
        {
            if (Numerals.ContainsKey(n)) return Numerals[n].ToString();
            return new string(Enumerable.Range(1, n).Select(_ => 'I').ToArray());
        } 
    }
}

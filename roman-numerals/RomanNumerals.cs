using System;
using System.Collections.Generic;
using System.Linq;

namespace roman_numerals
{
    public static class RomanNumerals
    {
        private static readonly IDictionary<int, char> Numerals = new Dictionary<int, char>()
        {
            { 1, 'I'},
            { 5, 'V'},
            { 10, 'X'},
            { 50, 'L'},
            { 100, 'C'},
            { 500, 'D'}
        };
        
        public static string ParseFromDecimal(int n, string accumulator = "")
        {
            if (n == 0) return accumulator;
            var digits = n.ToString().ToCharArray();
            var power = (int)Math.Pow(10, digits.Length - 1);
            var digit = int.Parse(digits[0].ToString());

            accumulator = digit switch
            {
                9 => (accumulator + Numerals[power] + Numerals[power * 10]),
                5 => (accumulator + Numerals[power * 5]),
                4 => (accumulator + Numerals[power] + Numerals[power * 5]),
                _ => (digit > 5) switch
                {
                    true => (accumulator + Numerals[power * 5] + PrintNTimes(Numerals[power], digit - 5)),
                    false => (accumulator + PrintNTimes(Numerals[power], digit))
                }
            };

            return ParseFromDecimal(RemoveFirstDigit(n), accumulator);
        }

        private static string PrintNTimes(char glyph, int n)
        {
            return new string(Enumerable.Range(0, n).Select(_ => glyph).ToArray());
        }

        public static int RemoveFirstDigit(int n)
        {
            var nStr = n.ToString();
            return nStr.Length > 1 ? int.Parse(nStr.Substring(1, nStr.Length - 1)) : 0;
        }
    }
}

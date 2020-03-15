using System;
using NUnit.Framework;
using roman_numerals;

namespace roman_numerals_tests
{
    public class RomanNumeralsTests
    {
        private static readonly (int, string)[] DecimalsMappedToRomanNumerals =
        {
            (1, "I"),
            (2, "II"),
            (3, "III"),
            (4, "IV")
        };
        
        [Theory, TestCaseSource(nameof(DecimalsMappedToRomanNumerals))]
        public void ShouldConvertDecimalsToRomanNumerals((int decimalFormat, string romanFormat) testCase)
        {
            var result = RomanNumerals.ParseFromDecimal(testCase.decimalFormat);
            Assert.AreEqual(testCase.romanFormat, result);
        }
    }
}

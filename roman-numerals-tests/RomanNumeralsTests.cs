using System;
using System.Security.Cryptography;
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
            (4, "IV"),
            (5, "V"),
            (6, "VI"),
            (7, "VII"),
            (8, "VIII"),
            (9, "IX"),
            (10, "X"),
            (11,"XI"),
            (12,"XII"),
            (13,"XIII"),
            (14,"XIV"),
            (15,"XV"),
            (16,"XVI"),
            (17,"XVII"),
            (18,"XVIII"),
            (19,"XIX"),
            (20,"XX"),
            (21,"XXI"),
            (40,"XL"),
            (41,"XLI"),
            (45,"XLV"),
            (49,"XLIX"),
            (50,"L"),
            (90,"XC"),
            (99,"XCIX"),
            (100,"C"),
            (400,"CD"),
        };
        
        [Theory, TestCaseSource(nameof(DecimalsMappedToRomanNumerals))]
        public void ShouldConvertDecimalsToRomanNumerals((int decimalFormat, string romanFormat) testCase)
        {
            var result = RomanNumerals.ParseFromDecimal(testCase.decimalFormat);
            Assert.AreEqual(testCase.romanFormat, result);
        }

        private static readonly (int, int)[] NumbersMappedToFirstDigitRemoved =
        {
            (1234, 234),
            (234, 34),
            (34, 4),
            (4, 0)
        };

        [Theory, TestCaseSource(nameof(NumbersMappedToFirstDigitRemoved))]
        public void RemoveFirstDigit_ShouldRemoveFirstDigitOfInteger((int input, int expectedResult) testCase)
        {
            var result = RomanNumerals.RemoveFirstDigit(testCase.input);

            Assert.AreEqual(testCase.expectedResult, result);
        }
    }
}

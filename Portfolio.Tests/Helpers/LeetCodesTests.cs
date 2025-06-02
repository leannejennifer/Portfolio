using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Portfolio.Helpers;
using Portfolio.Models;

namespace Portfolio.Tests.Helpers
{
    [TestFixture]
    public partial class LeetCodesTests
    {
        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        [TestCase(1001, true)]
        [TestCase(1011, false)]
        [TestCase(2345432, true)]
        [TestCase(23455432, true)]
        public void Plaindrome_Input_ExpectedOutcome(int input, bool expectedOutput)
        {
            // Given I input a value

            // When call Plaindrome
            var output = LeetCodes.IsPalindrome(input);
            // Then it should return the expected value
            Assert.That(output, Is.EqualTo(expectedOutput), $"When input is {input} we expect the output to be {expectedOutput}");
        }

        [TestCase("III", 3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void ToRomanNumerals_Input_ExpectedOutcome(string input, int expectedOutput)
        {
            // Given I have a valid roman numeral

            // When call toRomanNumerals 
            var result = LeetCodes.RomanToInt(input);
            // Then I expect the output to be the numerical version
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(new string[] { "flow", "flow" }, "flow")]
        [TestCase(new string[] { "flower", "flow", "flight" }, "fl")]
        [TestCase(new string[] { "dog", "racecar", "car" }, "")]
        [TestCase(new string[] { "ab", "a" }, "a")]
        public void LongestCommonPrefix_Input_ExpectedOutcome(string[] input, string expectedOutput)
        {
            // Given I have an array of strings

            // When call LongestCommonPrefix 
            var result = LeetCodes.LongestCommonPrefix(input);

            // Then I expect the output to be the longest common prefix
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
        [TestCase("Mr Ding", "rM gniD")]
        public void ReverseWords_Input_expectedOutcome(string input, string expectedOutput)
        {
            // When I call ReverseWords
            var result = LeetCodes.ReverseWords(input);

            // Then I should get the reversed string output
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
        [TestCase("hello", 13)]
        [TestCase("zaz", 50)]
        public void ScoreOfString_Input_expectedOutcome(string input, int expectedOutput)
        {
            // When I call ReverseWords
            var result = LeetCodes.ScoreOfString(input);

            // Then I should get the reversed string output
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(new int[] { 2, 11, 10, 1, 3 }, 10, 3)]
        [TestCase(new int[] { 1, 1, 2, 4, 9 }, 1, 0)]
        [TestCase(new int[] { 1, 1, 2, 4, 9 }, 9, 4)]
        [TestCase(new int[] { 69, 89, 57, 31, 84, 97, 50, 38, 91 }, 69, 4)]
        public void MinOperations_Input_expectedOutcome(int[] input, int k, int expectedOutput)
        {
            // When I call ReverseWords
            var result = LeetCodes.MinOperations(input, k);

            // Then I should get the reversed string output
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase("Hello World", 5)]
        [TestCase("   fly me   to   the moon  ", 4)]
        [TestCase("luffy is still joyboy", 6)]
        public void LengthOfLastWord_Input_ExpectedOutcome(string input, int expectedOutput)
        {
            // When I call LengthOfLastWord
            var result = LeetCodes.LengthOfLastWord(input);

            // Then I should get the length of the last word
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [TestCase(new int[] { 9 }, new int[] { 1, 0 })]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]
        public void PlusOne_Input_ExpectedOutput(int[] input, int[] expectedOutput)
        {
            // When I call PlusOne
            var result = LeetCodes.PlusOne(input);

            // Then I should get the incremented array
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(new int[] { 12, 345, 2, 6, 7896 }, 2)]
        [TestCase(new int[] { 555, 901, 482, 1771 }, 1)]
        public void FindNumbers_Input_ExpectedOutput(int[] input, int expectedOutput)
        {
            // When I call FindNumbers
            var result = LeetCodes.FindNumbers(input);

            // Then I should get a count of the integers with an even number of digits
            Assert.That(result, Is.EqualTo(expectedOutput));

        }

        //from work
        #region 1. TwoSum
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 7, new int[] { 0, 2 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSum_ReturnsCorrectIntArray(int[] input, int target, int[] expectedOutput)
        {
            // Given I have an array of integers

            // When I call TwoSum 
            var output = LeetCodes.TwoSum(input, target);

            // Then the two indexes of the numbers that add up to the target are returned
            Assert.That(output, Is.EqualTo(expectedOutput));
        }
        #endregion

        #region 2. Add two numbers
        [Ignore("Leaving this challenge for today")]
        [Test]//Case([2,4,3], [5,6,4])]
        public void AddTwoNumbers_ReturnsInReverseOrder()//ListNode l1, ListNode l2)
        {
            // Given I have two linked list nodes 

            // 243
            ListNode l1 = new(2, new(4, new(3)));
            // 564
            ListNode l2 = new(5, new(6, new(4)));
            // 807
            ListNode l3c = new(7, new(0, new(8)));

            // When I call AddTwoNumbers
            var output = LeetCodes.AddTwoNumbers(l1, l2);

            // Then I should get the expected output
            Assert.That(output, Is.EqualTo(l3c));
        }

        #endregion

        #region 20. Valid Parentheses
        [TestCase("()", true)]
        [TestCase("[]", true)]
        [TestCase("{[]}", true)]
        [TestCase("{[{}]}", true)]
        [TestCase("()[]{}", true)]
        [TestCase("((()))", true)]
        [TestCase("([])", true)]
        [TestCase("{([])}", true)]
        [TestCase("{(])}", false)]
        [TestCase("{(})}", false)]
        [TestCase("(((", false)]
        [TestCase("((()", false)]
        [TestCase("()))", false)]
        public void ValidParentheses_ReturnsExpectedValue(string input, bool expectedValue)
        {
            // Given I have a string of parentheses

            // When I call ValidParentheses

            // Then I should get the expected value
            Assert.That(LeetCodes.ValidParentheses(input), Is.EqualTo(expectedValue), $"{input} is{(expectedValue ? "" : " not")} complete.");
        }
        #endregion

        [TestCase(10, 3, 3)]
        [TestCase(7, -3, -2)]
        [TestCase(-2147483648, -1, 2147483647)]
        public void Divide_Input_ExpectedOutput(int dividend, int divisor, int expectedOutput)
        {
            // When I call Divide
            var result = LeetCodes.Divide(dividend, divisor);

            // Then it should return the quotient
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase("sadbutsad", "sad", 0)]
        [TestCase("leetcode", "leet", 0)]
        [TestCase("leecoldeleetleeto", "leeto", 12)]
        public void StrStr_Input_ExpectedOutput(string haystack, string needle, int expectedOutput)
        {
            // When I call StrStr
            var result = LeetCodes.StrStr(haystack, needle);
            // Then it will return the first index of needle

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [TestCase(new int[] { 1 }, 0, 0)]
        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 1, 3 }, 2, 1)]
        public void SearchInsert_Input_ExpectedOutput(int[] input, int target, int expectedOutput)
        {
            Assert.That(LeetCodes.SearchInsert(input, target), Is.EqualTo(expectedOutput));
        }

        [TestCase("/home/user/Documents/../Pictures", "/home/user/Pictures")]
        [TestCase("/home//foo/", "/home/foo")]
        [TestCase("/home/user/Documents/../Pictures", "/home/user/Pictures")]
        [TestCase("/../", "/")]
        [TestCase("/.../a/../b/c/../d/./", "/.../b/d")]
        public void SimplifyPath_Input_ExpectedOutput(string input, string expectedOutput)
        {
            Assert.That(LeetCodes.SimplifyPath(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(4, 2)]
        [TestCase(8, 2)]
        [TestCase(144, 12)]
        [TestCase(2147395600, 46340)]
        [TestCase(2147483647, 46340)]
        public void MySqrt_Input_ExpectedOutput(int input, int expectedOutput)
        {
            Assert.That(LeetCodes.MySqrt(input), Is.EqualTo(expectedOutput), $"The sqrt of {input} is {expectedOutput}");
        }

        [TestCase(9, false)]
        [TestCase(4, false)]
        public void IsStrictlyPalindromic_Input_ExpectedOutput(int input, bool expectedOutput)
        {
            Assert.That(LeetCodes.IsStrictlyPalindromic(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(3, "III")]
        [TestCase(58, "LVIII")]
        [TestCase(1994, "MCMXCIV")]
        public void IntToRoman_Input_ExpectedOutput(int input, string expectedOutput)
        {
            Assert.That(LeetCodes.IntToRoman(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(new[] { 2, 2, 1 }, 1)]
        [TestCase(new[] { 4, 1, 2, 1, 2 }, 4)]
        [TestCase(new[] { 1 }, 1)]
        public void SingleNumber(int[] input, int expectedOutput)
        {
            Assert.That(LeetCodes.SingleNumber(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(new int[] { 0, 2, 1, 5, 3, 4 }, new int[] { 0, 1, 2, 4, 5, 3 })]
        [TestCase(new int[] { 5, 0, 1, 2, 3, 4 }, new int[] { 4, 5, 0, 1, 2, 3 })]
        public void BuildArray(int[] input, int[] expectedOutput)
        {
            Assert.That(LeetCodes.BuildArray(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(36.50, new double[] { 309.65000, 97.70000 })]
        [TestCase(122.11, new double[] { 395.26000, 251.79800 })]
        public void ConvertTemperature(double input, double[] expectedOutput)
        {
            var result = LeetCodes.ConvertTemperature(input);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(10, 3, 19)]
        [TestCase(5, 6, 15)]
        public void DifferenceOfSums(int n, int m, int expectedOutput)
        {
            Assert.That(LeetCodes.DifferenceOfSums(n, m), Is.EqualTo(expectedOutput));
        }

        [TestCase(4, 1, 6)]
        [TestCase(3, 2, 7)]
        public void TheMaximumAchievableX(int num, int t, int expectedOutput)
        {
            Assert.That(LeetCodes.TheMaximumAchievableX(num, t), Is.EqualTo(expectedOutput));
        }

        [TestCase(new string[] { "leet", "code" }, "e", new int[] { 0, 1 })]
        [TestCase(new string[] { "abc", "bcd", "aaaa", "cbc" }, "a", new int[] { 0, 2 })]
        [TestCase(new string[] { "abc", "bcd", "aaaa", "cbc" }, "z", new int[] { })]
        public void FindWordsContaining(string[] words, char x, int[] expectedOutput)
        {
            Assert.That(LeetCodes.FindWordsContaining(words, x), Is.EqualTo(expectedOutput));
        }

        [TestCase(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1, 1, 2, 1 })]
        [TestCase(new int[] { 1, 3, 2, 1 }, new int[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
        public void GetConcatenation(int[] input, int[] expectedOutput)
        {
            Assert.That(LeetCodes.GetConcatenation(input), Is.EqualTo(expectedOutput));
        }

        [TestCase("1.1.1.1", "1[.]1[.]1[.]1")]
        [TestCase("255.100.50.0", "255[.]100[.]50[.]0")]
        public void DefangIPaddr(string input, string expectedOutput)
        {
            Assert.That(LeetCodes.DefangIPaddr(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(new int[] { 1, 2, 3, 1, 1, 3 }, 4)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 6)]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        public void NumIdenticalPairs(int[] input, int expectedOutput)
        {
            Assert.That(LeetCodes.NumIdenticalPairs(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(new string[] { "--X", "X++", "X++" }, 1)]
        [TestCase(new string[] { "++X", "++X", "X++" }, 3)]
        [TestCase(new string[] { "X++", "++X", "--X", "X--" }, 0)]
        public void FinalValueAfterOperations(string[] input, int expectedOutput)
        {
            Assert.That(LeetCodes.FinalValueAfterOperations(input), Is.EqualTo(expectedOutput));
        }

        [TestCase("aA", "aAAbbbb", 3)]
        [TestCase("z", "ZZ", 0)]
        
        public void NumJewelsInStones(string jewels, string stones, int expectedOutput)
        {
            Assert.That(LeetCodes.NumJewelsInStones(jewels, stones), Is.EqualTo(expectedOutput));
        }
    }
}

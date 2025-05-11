using Portfolio.Helpers;

namespace Portfolio.Tests.Helpers
{
    [TestFixture]
    public class LeetCodesTests
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

        [TestCase(new string[]{"flow", "flow"}, "flow")]
        [TestCase(new string[]{"flower", "flow", "flight"}, "fl")]
        [TestCase(new string[]{"dog", "racecar", "car"}, "")]
        [TestCase(new string[]{ "ab", "a"}, "a")]
        public void LongestCommonPrefix_Input_ExpectedOutcome(string[] input, string expectedOutput)
        {
            // Given I have an array of strings

            // When call LongestCommonPrefix 
            var result = LeetCodes.LongestCommonPrefix(input);

            // Then I expect the output to be the longest common prefix
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase("Let's take LeetCode contest","s'teL ekat edoCteeL tsetnoc")]
        [TestCase("Mr Ding","rM gniD")]
        public void ReverseWords_Input_expectedOutcome(string input, string expectedOutput)
        {
            // When I call ReverseWords
            var result = LeetCodes.ReverseWords(input);

            // Then I should get the reversed string output
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
        [TestCase("hello",13)]
        [TestCase("zaz",50)]
        public void ScoreOfString_Input_expectedOutcome(string input, int expectedOutput)
        {
            // When I call ReverseWords
            var result = LeetCodes.ScoreOfString(input);

            // Then I should get the reversed string output
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(new int[]{2,11,10,1,3}, 10, 3)]
        [TestCase(new int[]{1,1,2,4,9}, 1, 0)]
        [TestCase(new int[]{1,1,2,4,9}, 9, 4)]
        [TestCase(new int[]{69,89,57,31,84,97,50,38,91}, 69, 4)]
        public void MinOperations_Input_expectedOutcome(int[] input, int k, int expectedOutput)
        {
            // When I call ReverseWords
            var result = LeetCodes.MinOperations(input, k);

            // Then I should get the reversed string output
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
        
    }
}

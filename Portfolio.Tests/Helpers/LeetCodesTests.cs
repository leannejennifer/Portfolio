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
			// Given I 

			// When 

			// Then 
		}

	}
}

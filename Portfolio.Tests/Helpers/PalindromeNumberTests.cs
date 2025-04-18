namespace Portfolio.Tests.LeetCodes
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
            var output = Helpers.LeetCodes.IsPalindrome(input);
			// Then it should return the expected value
			Assert.That(output, Is.EqualTo(expectedOutput), $"When input is {input} we expect the output to be {expectedOutput}");
		}

	}
}

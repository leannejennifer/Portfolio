using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Portfolio.Helpers;
using Portfolio.Models;

namespace Portfolio.Tests.Helpers
{
    [TestFixture]
    public partial class LeetCodesTests
    {
        [TestCase(new int[] { 1, 3, 2 }, 2)]
        [TestCase(new int[] { 1, 10, 11 }, 1)]
        [TestCase(new int[] { 1, 2, 3 }, -1)]
        public void SmallestIndex_Input_ExpectedOutput(int[] input, int expectedOutput)
        {
            Assert.That(LeetCodes.SmallestIndex(input), Is.EqualTo(expectedOutput));
        }

    }
}
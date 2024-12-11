using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Tests
{
    [TestFixture]
    public class NumberHelperTest
    {
        [TestCase("1 2 3 4 5", "5 1")]
        [TestCase("1 2 -3 4 5", "5 -3")]
        [TestCase("1 9 3 4 -5", "9 -5")]
        [TestCase("1 9 3 40 -5", "40 -5")]

		public void HighAndLow_InputListOfIntAsString_ReturnsHighestAndLowestNumber(string input, string output)
		{
            //Arrange

            //Act
            var highAndLow = NumberHelper.HighAndLow(input);
            //Assert
            Assert.That(highAndLow, Is.EqualTo(output));
		}

	}
}

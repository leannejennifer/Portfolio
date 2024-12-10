using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Tests
{
    [TestFixture]
    public class StringHelperTest
    {
        [Test]
        public void ReverseString_InputString_ReversedStringReturned()
        {
            //Arrange
            var input = "hello";
            var expectedResult = "olleh";
            //Act
            var reversedString = StringHelper.ReverseString(input);
            //Assert
            Assert.That(reversedString, Is.EqualTo(expectedResult));
        }
        [TestCase("leanne", "ennael")]
        [TestCaseSource(nameof(ReversedStringTestData))]
        public void ReverseString_InputString_ReversedStringReturned(string input, string expectedResult)
        {
            //Arrange

            //Act
            var reversedString = StringHelper.ReverseString(input);
            //Assert
            Assert.That(reversedString, Is.EqualTo(expectedResult));
        }

        private static readonly object[] ReversedStringTestData =
        [
            // check it ignores case
            new object[]{"Homely","ylemoh"},
        ];
    }
}

using Portfolio.Helpers;

namespace Portfolio.Tests
{
    [TestFixture]
    public class StringHelperTest
    {
        #region ReversedString
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
        #endregion

        #region CountVowels

        [TestCaseSource(nameof(_vowelTestData))]
        public void CalculateVowelCount_InputHasVowels_ReturnsNumberOfVowels(string input, int expectedNumber)
        {
            //Arrange

            //Act
            var numberOfVowels = StringHelper.CalculateVowelCount(input);
            //Assert
            Assert.That(numberOfVowels, Is.EqualTo(expectedNumber));
        }

        [TestCaseSource(nameof(_vowelTestData))]
        public void CalculateVowelCountLinq_InputHasVowels_ReturnsNumberOfVowels(string input, int expectedNumber)
        {
            //Arrange

            //Act
            var numberOfVowels = StringHelper.CalculateVowelCountLinq(input);
            //Assert
            Assert.That(numberOfVowels, Is.EqualTo(expectedNumber));
        }
        [TestCaseSource(nameof(_vowelTestData))]
        public void CalculateVowelCountHash_InputHasVowels_ReturnsNumberOfVowels(string input, int expectedNumber)
        {
            //Arrange

            //Act
            var numberOfVowels = StringHelper.CalculateVowelCountHash(input);
            //Assert
            Assert.That(numberOfVowels, Is.EqualTo(expectedNumber));
        }

        private static readonly object[] _vowelTestData = [
            new object[] {"hello", 2},
            new object[] {"roooool", 5},
            new object[] {"apples", 2},
            new object[] {"my", 0},

            ];

        #endregion

        #region

        [TestCase("Pig latin is cool", "igPay atinlay siay oolcay")]
        [TestCase("Hello world !", "elloHay orldway !")]

        public void PigLatin_InputString_ReturnStringInCorrectFormat(string input, string output)
        {
            //Arrange

            //Act
            var formattedString = StringHelper.PigLatin(input);
            //Assert
            Assert.That(formattedString, Is.EqualTo(output));
        }


        #endregion
    }
}

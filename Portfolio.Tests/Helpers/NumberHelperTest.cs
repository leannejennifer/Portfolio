using Portfolio.Helpers;

namespace Portfolio.Tests.Helpers
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
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(50)]

        public void GetRandomNumber_NoInput_ReturnsRandom(int maxLimit)
        {
            //Arrange

            //Act
            var randomNumber = NumberHelper.GetRandomNumber(maxLimit);
            //Assert
            Assert.That(randomNumber, Is.LessThan(maxLimit));
        }

        [TestCase(6, 0)]
        [TestCase(6, 1)]
        [TestCase(6, 2)]
        [TestCase(6, 3)]
        [TestCase(6, 4)]
        [TestCase(6, 5)]
        public void GetRandomNumber_NoInput_DoesNotReturnPrevious(int maxLimit, int previousValue)
        {
            //Arrange

            //Act
            var randomNumber = NumberHelper.GetRandomNumber(maxLimit, previousValue);
            //Assert
            Assert.That(randomNumber, Is.Not.EqualTo(previousValue));
        }
    }
}

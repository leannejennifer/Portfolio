namespace Portfolio.Tests
{
    [TestFixture(Category ="FizzBuzz")]
    public class FizzBuzzTest
    {
        private StringWriter _writer;

        [TearDown]
        public void TearDown()
        {
            Console.SetOut(Console.Out);
            _writer.Dispose();
        }

        [TestCase(3)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        [TestCase(21)]
        public void GetFizzBuzzWord_DivisibleByThree_OutputFizz(int index)
        {
            //Arrange
            _writer = new StringWriter();
            Console.SetOut(_writer);
            //Act
            FizzBuzz.DisplayFizzBuzzWord(index);
            //Assert
            var actualOutput = _writer.ToString();
            Assert.That(actualOutput.TrimEnd(), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GetFizzBuzzWord_DivisibleByFive_OutputBuzz(int index)
        {
            //Arrange
            _writer = new StringWriter();
            Console.SetOut(_writer);
            //Act
            FizzBuzz.DisplayFizzBuzzWord(index);
            //Assert
            var actualOutput = _writer.ToString();
            Assert.That(actualOutput.TrimEnd(), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void GetFizzBuzzWord_DivisibleByBothThreeAndFive_OutputFizzBuzz(int index)
        {
            //Arrange
            _writer = new StringWriter();
            Console.SetOut(_writer);
            //Act
            FizzBuzz.DisplayFizzBuzzWord(index);
            //Assert
            var actualOutput = _writer.ToString();
            Assert.That(actualOutput.TrimEnd(), Is.EqualTo("FizzBuzz"));
        }

        [TestCase(31)]

        public void GetFizzBuzzWord_NotDivisibleByThreeOrFive_OuputNumber(int index)
        {
            //Arrange
            _writer = new StringWriter();
            Console.SetOut(_writer);
            //Act
            FizzBuzz.DisplayFizzBuzzWord(index);
            //Assert
            var actualOutput = _writer.ToString();
            Assert.That(actualOutput.TrimEnd(), Is.EqualTo(index.ToString()));
        }

        // Refactored version
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(31, "31")]
        public void GetFizzBuzzWord_InputNumber_OutputCorrectResponse(int input, string output)
        {
            //Arrange
            _writer = new StringWriter();
            Console.SetOut(_writer);
            //Act
            FizzBuzz.DisplayFizzBuzzWord(input);
            //Assert
            var actualOutput = _writer.ToString();
            Assert.That(actualOutput.TrimEnd(), Is.EqualTo(output));
        }

    }
}

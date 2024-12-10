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
        public void DisplayFizzBuzzWord_DivisibleByThree_OutputFizz(int index)
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
        [TestCase(55)]
        [TestCase(25)]
        public void DisplayFizzBuzzWord_DivisibleByFive_OutputBuzz(int index)
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
        public void DisplayFizzBuzzWord_DivisibleByBothThreeAndFive_OutputFizzBuzz(int index)
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

        public void DisplayFizzBuzzWord_NotDivisibleByThreeOrFive_OuputNumber(int index)
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
        // This method allows you to set up test data with object arrays
        [TestCaseSource(nameof(TestItemData))]
        public void DisplayFizzBuzzWord_InputNumber_OutputCorrectResponse(int input, string output)
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

        public static object[] TestItemData =
        {
            new object[] {1, "1"},
            new object[] {2, "2"},
            new object[] {3, "Fizz"},
            new object[] {4, "4"},
            new object[] {5, "Buzz"},
            new object[] {6, "Fizz"},
            new object[] {7, "7"},
            new object[] {8, "8"},
            new object[] {9, "Fizz"},
            new object[] {10, "Buzz"},
            new object[] {11, "11"},
            new object[] {12, "Fizz"},
            new object[] {13, "13"},
            new object[] {14, "14"},
            new object[] {15, "FizzBuzz"},
            new object[] {16, "16"},
            new object[] {17, "17"},
            new object[] {18, "Fizz"},
            new object[] {19, "19"},
            new object[] {20, "Buzz"},
            new object[] {21, "Fizz"},
            new object[] {22, "22"},
            new object[] {23, "23"},
            new object[] {24, "Fizz"},
            new object[] {25, "Buzz"},
            new object[] {26, "26"},
            new object[] {27, "Fizz"},
            new object[] {28, "28"},
            new object[] {29, "29"},
            new object[] {30, "FizzBuzz"},
            new object[] {31, "31"},
            new object[] {32, "32"},
            new object[] {33, "Fizz"},
            new object[] {34, "34"},
            new object[] {35, "Buzz"},
            new object[] {36, "Fizz"},
            new object[] {37, "37"},
            new object[] {38, "38"},
            new object[] {39, "Fizz"},
            new object[] {40, "Buzz"},
            new object[] {41, "41"},
            new object[] {42, "Fizz"},
            new object[] {43, "43"},
            new object[] {44, "44"},
            new object[] {45, "FizzBuzz"},
            new object[] {46, "46"},
            new object[] {47, "47"},
            new object[] {48, "Fizz"},
            new object[] {49, "49"},
            new object[] {50, "Buzz"},
            new object[] {51, "Fizz"},
            new object[] {52, "52"},
            new object[] {53, "53"},
            new object[] {54, "Fizz"},
            new object[] {55, "Buzz"},
            new object[] {56, "56"},
            new object[] {57, "Fizz"},
            new object[] {58, "58"},
            new object[] {59, "59"},
            new object[] {60, "FizzBuzz"},
            new object[] {61, "61"},
            new object[] {62, "62"},
            new object[] {63, "Fizz"},
            new object[] {64, "64"},
            new object[] {65, "Buzz"},
            new object[] {66, "Fizz"},
            new object[] {67, "67"},
            new object[] {68, "68"},
            new object[] {69, "Fizz"},
            new object[] {70, "Buzz"},
            new object[] {71, "71"},
            new object[] {72, "Fizz"},
            new object[] {73, "73"},
            new object[] {74, "74"},
            new object[] {75, "FizzBuzz"},
            new object[] {76, "76"},
            new object[] {77, "77"},
            new object[] {78, "Fizz"},
            new object[] {79, "79"},
            new object[] {80, "Buzz"},
            new object[] {81, "Fizz"},
            new object[] {82, "82"},
            new object[] {83, "83"},
            new object[] {84, "Fizz"},
            new object[] {85, "Buzz"},
            new object[] {86, "86"},
            new object[] {87, "Fizz"},
            new object[] {88, "88"},
            new object[] {89, "89"},
            new object[] {90, "FizzBuzz"},
            new object[] {91, "91"},
            new object[] {92, "92"},
            new object[] {93, "Fizz"},
            new object[] {94, "94"},
            new object[] {95, "Buzz"},
            new object[] {96, "Fizz"},
            new object[] {97, "97"},
            new object[] {98, "98"},
            new object[] {99, "Fizz"},
            new object[] {100, "Buzz"},
        };
    }
}

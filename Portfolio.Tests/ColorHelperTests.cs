using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Enums;
using Portfolio.Helpers;

namespace Portfolio.Tests
{
    [TestFixture]
    public class ColorHelperTests
    {
        [TestCase(0,Colors.Red)]
        [TestCase(1,Colors.Blue)]
        [TestCase(2,Colors.Yellow)]
        [TestCase(3,Colors.Green)]
        [TestCase(4,Colors.Pink)] 
        public void GetColorFromEnum_IndexExists_ReturnCorrectColor(int index, Colors expectedOutput)
		{
            //Arrange

            //Act
            var color = ColorHelper.GetColorFromEnum(index);
            //Assert
            Assert.That(color, Is.EqualTo(expectedOutput));
        }

        [TestCase(5)]
        public void GetColorFromEnum_IndexDoesNotExist_ReturnEmptyString(int index)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<IndexOutOfRangeException>(() => ColorHelper.GetColorFromEnum(index));
        }

    }
}

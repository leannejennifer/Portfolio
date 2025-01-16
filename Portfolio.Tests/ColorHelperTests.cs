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
        [TestCase(5,Colors.Purple)] 
        public void GetColorFromEnum_IndexExists_ReturnCorrectColor(int index, Colors expectedOutput)
		{
            //Arrange

            //Act
            var color = ColorHelper.GetColorFromEnum(index);
            //Assert
            Assert.That(color, Is.EqualTo(expectedOutput));
        }

        [TestCase(6)]
        public void GetColorFromEnum_IndexDoesNotExist_ThrowsIndexOutOfRange(int index)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<IndexOutOfRangeException>(() => ColorHelper.GetColorFromEnum(index));
        }

        [Test]
        public void GetRandomColor_NoInput_DoesNotThrowException()
        {
            //Arrange
            
            //Act

            //Assert
            Assert.DoesNotThrow(() => ColorHelper.GetRandomColor());
        }

        //[Test]
        //public void GetRandomColor_CurrentColorSet_CannotReturnSameColor()
        //{
        //    //Arrange
        //    //Act

        //    //Assert
        //    Assert.DoesNotThrow(() => ColorHelper.GetRandomColor());
        //}

    }
}

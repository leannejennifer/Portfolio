using Portfolio.Helpers;

namespace Portfolio.Tests.Helpers
{
    [TestFixture]
    public class SortingHelperTest
    {
        [TestCase(new int[] { 1, 4, 5, 7, 8, 9, 0, 23, 54, 3, 6 }, new int[] { 0, 1, 3, 4, 5, 6, 7, 8, 9, 23, 54 })]

        public void BubbleSort_UnorderedList_ReturnsOrderedList(int[] unsortedInts, int[] expectedSortedInts)
        {
            //Arrange

            //Act
            var sortedInts = SortingHelper.BubbleSort(unsortedInts);
            //Assert
            Assert.That(sortedInts, Is.EquivalentTo(expectedSortedInts));
        }

        [TestCase(new int[] { 1, 4, 5, 7, 8, 9, 0, 23, 54, 3, 6 }, new int[] { 0, 1, 3, 4, 5, 6, 7, 8, 9, 23, 54 })]
        public void BubbleSortWhile_UnorderedList_ReturnsOrderedList(int[] unsortedInts, int[] expectedSortedInts)
        {
            //Arrange

            //Act
            var sortedInts = SortingHelper.BubbleSortWhile(unsortedInts);
            //Assert
            Assert.That(sortedInts, Is.EquivalentTo(expectedSortedInts));
        }

    }
}

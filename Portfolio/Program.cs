namespace Portfolio;
public class Program
{
    private static void Main(string[] args)
    {
        //for (int i = 1; i <= 100; i++)
        //{
        //    FizzBuzz.DisplayFizzBuzzWord(i);
        //}

        SortingHelper.BubbleSort(new int[] { 1, 4, 5, 7, 8, 9, 0, 23, 54, 3, 6 });
        SortingHelper.BubbleSortWhile(new int[] { 1, 4, 5, 7, 8, 9, 0, 23, 54, 3, 6 });
    }

}
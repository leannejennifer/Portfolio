namespace Portfolio
{
    public static class SortingHelper
    {
        static void DisplayArray(int[] arr) => Console.WriteLine(string.Join(" ", arr));
        //not optimal for large datasets
        public static int[] BubbleSortWhile(int[] ints)
        {
            int[] sortedInts = ints;

            var unsorted = true;

            //slower implementation as the last value will be in place already
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < sortedInts.Length - 1; i++)
                {
                    // if current value is larger than the one after the value are switched.
                    if (sortedInts[i] > sortedInts[i + 1])
                    {
                        var tempInt = sortedInts[i];
                        sortedInts[i] = sortedInts[i + 1];
                        sortedInts[i + 1] = tempInt;
                        unsorted = true;
                    }
                }
            }

            return sortedInts;
        }
        //This is more efficient as it does less iterations
        public static int[] BubbleSort(int[] ints)
        {
            int[] sortedInts = ints;

            var swapped = false;

            // iterates through array
            for(int j = 0; j < sortedInts.Length - 1; j++)
            {
                swapped = false;
                ///In each pass, the largest element bubbles up to the end so you don't need to check the last value
                for (int i = 0; i < sortedInts.Length - 1 - j; i++)
                {
                    // if current value is larger than the one after the value are switched.
                    if (sortedInts[i] > sortedInts[i + 1])
                    {
                        var tempInt = sortedInts[i];
                        sortedInts[i] = sortedInts[i + 1];
                        sortedInts[i + 1] = tempInt;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }

            return sortedInts;
        }
    }
}

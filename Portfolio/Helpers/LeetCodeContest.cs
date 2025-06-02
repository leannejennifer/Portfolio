namespace Portfolio.Helpers
{
    public static partial class LeetCodes
    {
        #region 450. Smallest Index
        public static int SmallestIndex(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                int? amount = 0;

                var digits = nums[i].ToString().ToCharArray();
                foreach (var digit in digits)
                {
                    amount += int.Parse(digit.ToString());
                }

                if (amount == i)
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion

    }
}

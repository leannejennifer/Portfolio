namespace Portfolio.Helpers
{
    public static class LeetCodes
    {
        // 9.
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var str = x.ToString();

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[^(i + 1)])
                    return false;
            }
            return true;
        }

        // 13.
        public static int RomanToInt(string s)
        {
            //
            //Symbol Value
            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000

            //I can be placed before V (5) and X (10) to make 4 and 9. 
            //X can be placed before L(50) and C(100) to make 40 and 90.
            //C can be placed before D(500) and M(1000) to make 400 and 900.
            return 0;
        }
    }
}

using System.Text;

namespace Portfolio.Helpers
{
    public static class LeetCodes
    {
        #region 9. IsPalindrome
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
        #endregion
        #region 13. Roman to int

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

            var result = 0;
            char? prev = null;
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                switch (c)
                {
                    case 'I':
                        result++;
                        break;
                    case 'V':
                        result += prev == 'I' ? 3: 5;
                        break;
                    case 'X':
                        result += prev == 'I' ? 8 : 10;
                        break;
                    case 'L':
                        result += prev == 'X' ? 30 : 50;
                        break;
                    case 'C':
                        result += prev == 'X' ? 80 : 100;
                        break;
                    case 'D':
                        result += prev == 'C' ? 300 : 500;
                        break;
                    case 'M':
                        result += prev == 'C' ? 800 : 1000;
                        break;
                }
                prev = c;
            }

            return result;
        }
        #endregion
        #region 14. Longest Common Prefix
        public static string LongestCommonPrefix(string[] strs)
        {
            var startingWord = strs[0];
            StringBuilder sb = new();
            for(var i = 0; i < startingWord.Length; i++)
            { 
                for(var j = 1; j < strs.Length; j++)
                {
                    var currentString = strs[j];
                    if (currentString.Length <= i || currentString[i] != startingWord[i])
                    {
                        return sb.ToString();
                    }
                    
                }
                sb.Append(startingWord[i]);
            
            }

            return sb.ToString();
        }
        #endregion
        #region 557. Reverse Words in a String III
        public static string ReverseWords(string s) {
            
            StringBuilder sb = new();

            var words = s.Split( );
            foreach (var (word, index) in words.Select((word, index) => (word, index)))
            {
                for (var i = word.Length - 1; i > -1; i--)
                {
                    sb.Append(word[i]);
                }
                if (index < words.Length - 1)
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }
        #endregion
        
    }
}

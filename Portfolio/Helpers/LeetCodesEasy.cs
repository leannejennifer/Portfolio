using System.Text;
using Portfolio.Models;

namespace Portfolio.Helpers
{
    public static partial class LeetCodes
    {
        #region 1. Two Sum
        /// <summary>
        /// Returns the indexes of the integers in the array that add up to the target.
        /// Has exactly one solution.
        /// Cannot use the same element twice.
        /// <paramref name="nums">Array of integers.</paramref>
        /// <paramref name="target">Target value</paramref>
        /// </summary>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var value = nums[i] + nums[j];
                    if (value == target)
                    {
                        return [i, j];
                    }
                }
            }

            throw new InvalidDataException();
        }

        #endregion
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
                        result += prev == 'I' ? 3 : 5;
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
            for (var i = 0; i < startingWord.Length; i++)
            {
                for (var j = 1; j < strs.Length; j++)
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
        #region 20. Valid Parentheses
        public static bool ValidParentheses(string input)
        {
            // Open brackets must be closed by the same type of brackets.
            // Open brackets must be closed in the correct order.
            // Every close bracket has a corresponding open bracket of the same type.

            List<char> chrs = [];

            foreach (var c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    chrs.Add(c);
                }
                else
                {
                    if (chrs.Count == 0 || !MatchPrevious(c, chrs[^1]))
                        return false;
                    else
                        chrs.RemoveAt(chrs.Count - 1);
                }
            }

            return chrs.Count == 0;
        }

        private static bool MatchPrevious(char c, char previousC)
        {
            return c switch
            {
                '}' => previousC == '{',
                ')' => previousC == '(',
                ']' => previousC == '[',
                _ => false,
            };
        }
        #endregion
        #region 28. Find the Index of the First Occurrence in a String
        public static int StrStr(string haystack, string needle)
        {
            for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (haystack.Substring(i, needle.Length) == needle)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
        #endregion
        #region 35. Search Insert Position
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums[0] >= target)
                return 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] < target)
                {
                    continue;
                }

                return i;
            }

            return nums.Length;
        }
        #endregion
        #region 58. Length of Last Word
        public static int LengthOfLastWord(string s)
        {
            return s.Trim().Split(" ")[^1].Length;
        }
        #endregion
        #region 66. Plus one
        public static int[] PlusOne(int[] digits)
        {

            var resultDigits = new List<int>();
            int addOne = 1;

            for (int i = digits.Length - 1; i > -1; i--)
            {
                var result = digits[i] + addOne;

                if (result > 9)
                {
                    resultDigits.Insert(0, result - 10);
                    addOne = 1;

                    if (i == 0)
                    {
                        resultDigits.Insert(0, 1);
                    }
                }
                else
                {
                    resultDigits.Insert(0, result);
                    addOne = 0;
                }
            }
            return resultDigits.ToArray();

        }
        #endregion
        #region 69. Sqrt(x)
        public static int MySqrt(int x)
        {
            if (x >= 2147395600)
            {
                return 46340;
            }
            int a = 0;

            while ((a * a) <= x)
            {
                a++;
            }
            return a - 1;
        }
        #endregion
        #region 136. Single Number
        public static int SingleNumber(int[] nums)
        {
            List<int> ints = [];
            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];

                if (!ints.Remove(current))
                {
                    ints.Add(current);
                }
            }
            return ints[0];
        }
        #endregion

        #region 557. Reverse Words in a String III
        public static string ReverseWords(string s)
        {

            StringBuilder sb = new();

            var words = s.Split();
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
        #region 1295. Find Numbers with Even Number of Digits
        public static int FindNumbers(int[] nums)
        {
            var a = 0;

            foreach (var num in nums)
            {
                if (num.ToString().Length % 2 == 0)
                    a++;
            }
            return a;
        }
        #endregion
        #region 3110. Score of a string
        public static int ScoreOfString(string s)
        {
            int result = 0;
            for (var i = 1; i < s.Length; i++)
            {
                int prevVal = s[i - 1];
                result += Math.Abs(prevVal - s[i]);
            }

            return result;
        }
        #endregion
        #region 3065. Minimum Operations to Exceed Threshold Value I
        public static int MinOperations(int[] nums, int k)
        {

            return nums.Count(d => d < k);
        }
        #endregion
    }
}

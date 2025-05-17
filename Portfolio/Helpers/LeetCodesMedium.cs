using System.Text;
using Portfolio.Models;

namespace Portfolio.Helpers
{
    public static partial class LeetCodes
    {

        #region WIP: 2. Add Two Numbers

        /// <summary>
        /// Given two non empty, non-negative, single digit ListNodes 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var currentL1 = l1;
            var currentL2 = l2;
            ListNode output = new();
            var doubleFigures = 0;

            while (currentL1 != null && currentL2 != null)
            {
                var result = currentL1.val + currentL2.val + doubleFigures;


                output = new ListNode(result, output);

                currentL1 = currentL1.next;
                currentL2 = currentL2.next;
            }

            return output;
        }

        #endregion

        #region 29. Divide Two Integers
        public static int Divide(int dividend, int divisor)
        {
            Int64 result = (Int64)dividend / (Int64)divisor;

            if (result > int.MaxValue)
                return int.MaxValue;

            if (result < int.MinValue)
                return int.MinValue;

            return (int)result;
        }
        #endregion

        #region 71. Simplify Path
        public static string SimplifyPath(string path)
        {

            var sections = path.Split('/');
            List<string> strings = [];

            foreach (var section in sections)
            {
                if (section == "" || section == ".")
                    continue;

                if (section == "..")
                {
                    if (strings.Count - 1 != -1)
                        strings.RemoveAt(strings.Count - 1);
                    continue;
                }

                strings.Add(section);
            }

            return '/' + string.Join("/", strings);
        }
        #endregion

        #region 2396. Strictly Palindromic Number
        public static bool IsStrictlyPalindromic(int n)
        {
            for (int i = 2; i < n - 1; i++)
            {
                var input = n;
                var binary = "";
                while (input > 0)
                {
                    binary = (input % i) + binary;
                    input /= i;
                }

                for (int j = 0; j < binary.Length / 2; j++)
                {
                    if (binary[j] != binary[^(j + 1)])
                        return false;
                }
            }

            return true;
        }
        #endregion
    }
}

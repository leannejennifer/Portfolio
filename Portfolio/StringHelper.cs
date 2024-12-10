using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public static class StringHelper
    {
        public static string ReverseString(string inputString)
        {
            var lowercaseInput = inputString.ToLower();

            // Use string builder as it is more efficient
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = lowercaseInput.Length-1; i>=0; i--)
            {
                stringBuilder.Append(lowercaseInput[i]);
            }

            return stringBuilder.ToString();
        }

    }
}

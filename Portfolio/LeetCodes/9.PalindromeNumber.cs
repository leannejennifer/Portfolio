﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.LeetCodes
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var str = x.ToString();

            for(int i=0; i < str.Length/2; i++)
            {
                if (str[i] != str[^(i+1)])
                    return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public static class NumberHelper
    {
        // no linq
        // space separator
        // at least one number
        // one number same twice
        public static string HighAndLow(string input)
        {
            var numbers = input.Split(" ");

            var highNumber = int.MinValue;
            var lowNumber = int.MaxValue;

            for(int i = 0; i < numbers.Length; i++)
            {
                var number = int.Parse(numbers[i]);

                if (number < lowNumber)
                {
                    lowNumber = number;
                }

                if (number > highNumber)
                {
                    highNumber = number;
                }
            }

            return highNumber + " " + lowNumber;
        }
    }
}

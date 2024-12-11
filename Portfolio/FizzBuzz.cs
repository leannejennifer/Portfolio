using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public class FizzBuzz
    {
        public static void DisplayFizzBuzzWord(int index)
        {
            if (index % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (index % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (index % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}

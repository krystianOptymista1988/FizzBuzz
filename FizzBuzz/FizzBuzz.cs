using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string test(int gamenumber)
        {
            int checkFizz = gamenumber % 3;
            int checkBuzz = gamenumber % 5;

            if (checkFizz == 0 && checkBuzz == 0)
            {
                return "FizzBuzz";
            }
            else if (checkBuzz == 0)
            { 
                return "Buzz";
            }
            else if (checkFizz == 0)
            {
                return "Fizz";
            }
            else
            {
                return (gamenumber.ToString());
            }
        }
    }

}


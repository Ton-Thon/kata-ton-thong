using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata._01_FizzBuzz
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            if(number % 3 == 0)
            {
                return "Fizz";
            }

            if(number == 5)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
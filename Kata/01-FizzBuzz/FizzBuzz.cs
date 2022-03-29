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
            if(number == -1 || number == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            if (IsFizz(number) && IsBuzz(number))
            {
                return "FizzBuzz";
            }

            if (IsFizz(number))
            {
                return "Fizz";
            }

            if(IsBuzz(number))
            {
                return "Buzz";
            }

            return number.ToString();
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}
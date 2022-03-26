using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Generate(int number)
        {
            if (IsDivisionByNumber(number,15)) return "FizzBuzz";
            if (IsDivisionByNumber(number,3)) return "Fizz";
            if (IsDivisionByNumber(number,5)) return "Buzz";
            return number.ToString();


        }

        private bool IsDivisionByNumber(int number, long divisor)
        {
            return number % divisor == 0;
        }

    }
}

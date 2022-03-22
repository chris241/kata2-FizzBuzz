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
            if (IsDivisionBy15(number)) return "FizzBuzz";
            if (IsDivisionBy3(number)) return "Fizz";
            if (IsDivisionBy5(number)) return "Buzz";
            return number.ToString();


        }

        private static bool IsDivisionBy5(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsDivisionBy3(int number)
        {
            return number % 3 == 0;
        }

        private bool IsDivisionBy15(int number)
        {
            return number % 15 == 0;
        }
    }
}

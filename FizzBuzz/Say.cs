using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class Say
    {
        private string sayWhat;

        public string SayFizzBuzz(int order)
        {
            if (order % 3 == 0)
            {
                sayWhat += "Fizz";
            }

            if (order % 5 == 0)
            {
                sayWhat += "Buzz";
            }

            if (order % 7 == 0)
            {
                sayWhat += "Whizz";
            }

            return sayWhat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.tests
{
    public class Calculator
    {
        public string DetermineOutputBaseOnMultiple(int input)
        {
            if (input % 3 == 0)
            {
                return "fizz";
            }
            else if (input % 5 == 0)
            {
                return "buzz";
            }

            return "notfizz";
        }

        public string IsMultipleOfFive(int input)
        {
            if (input % 5 == 0)
            {
                return "fizz";
            }

            return "notfizz";
        }
    }
}

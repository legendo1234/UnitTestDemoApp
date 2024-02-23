using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UnitTestHomework
{
    public  class MathOperations
    {
        public int Addition(int number1, int number2)
        {
            int output = 0;

            output = number1 + number2;

            return output;

        }
        public int Subtraction(int number1, int number2)
        {
            int output = 0;

            output = number1 - number2;

            return output;
        }
        public int Multiplication(int number1, int number2)
        {
            int output = 0;

            output = number1 * number2;

            return output;
        }
        public int Division(int number1, int number2)
        {
            int output = 0;

            output = number1 / number2;

            return output;
        }

    }
}

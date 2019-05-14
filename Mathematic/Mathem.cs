using System;

namespace Mathematic
{
    public class Mathem
    {
        public int Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }

        public long Factorial(long factorial)
        {
            if (factorial<0)
            {
                throw new ArgumentException("Factorialnumber < 0 but it should be > 0");
            }
            if (factorial == 0)
            {
                return 1;
            }
            
            long result = 1;
            for (int count = 1; count <= factorial; count++)
            {
                result = count * result;
            }

            return result;
        }

        public int Power(int number, int degree)
        {
            int result = 1;
            for (int i = 1; i <= degree; i++)
            {
                result = result * number;
            }

            return result;
        }
    }
}
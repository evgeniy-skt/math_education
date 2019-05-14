using System;

namespace Mathematic
{
    class Program
    {
        static void Main()
        {
            var multiplicationTwoNumber = new Mathem();
            var multiplicationTwoNumberResult = multiplicationTwoNumber.Multiplication(2, 5);
            var numberFactorial = multiplicationTwoNumber.Factorial(-14);
            var numberPower = multiplicationTwoNumber.Power(2, 1);
            Console.WriteLine($"{multiplicationTwoNumberResult}");
            Console.WriteLine($"{numberFactorial}");
            Console.WriteLine($"{numberPower}");
        }
    }
}
using System;
using Mathematic;
using NUnit.Framework;

namespace MathematicTest
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 0, 0)]
        [TestCase(0, 0, 0)]
        public void WhenMultiplicationArgumentsIsValid_ShouldCorrectCount(int multiplicationNumber1, int multiplicationNumber2,
            int multiplicationResult)
        {
            var mathem = new Mathem();

            var result = mathem.Multiplication(multiplicationNumber1, multiplicationNumber2);

            Assert.AreEqual(multiplicationResult, result);
        }

        [Test]
        [TestCase(6,720)]
        [TestCase(14,87178291200)]
        [TestCase(0,1)]
        [TestCase(1,1)]
        public void WhenFactorialArgumentsIsValid_ShouldCorrectCount(int factorialNumber, long factorialResult)
        {
            var mathem = new Mathem();
            
            var result = mathem.Factorial(factorialNumber);
            
            Assert.AreEqual(factorialResult, result);
        }
        // TODO написать еще один тест с ассертом на эксепшн отрицательного значения
       
        [Test]
        public void WhenAFactorialrgumentIsInvalid_ShouldShowException()
        {

            Assert.Throws<ArgumentException>(_TestBody);
        }
        
        private void _TestBody()
        {
            int test = -14;
            var mathem = new Mathem();
            var result = mathem.Factorial(test);
        }

        [Test]
        [TestCase(0,0,1)]
        [TestCase(0,1,0)]
        [TestCase(1,1,1)]
        [TestCase(2,2,4)]
        [TestCase(2,20,1048576)]
        [TestCase(10,0,1)]
        public void WhenPowerArgumentsIsValid_ShouldCorrectCount(int powerNumber, int powerDegree, int powerResult)
        {
            var mathem = new Mathem();

            var result = mathem.Power(powerNumber, powerDegree);
            
            Assert.AreEqual(powerResult, result);
        }
    }
    
}
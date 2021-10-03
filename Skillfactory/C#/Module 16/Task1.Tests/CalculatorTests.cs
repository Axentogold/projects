using System;
using NUnit.Framework;


namespace Task1.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        Calculator calc = new Calculator();

        
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Additional(10, 12), 22);
            Assert.AreEqual(calc.Additional(-5, 3), -2);

            Assert.AreNotEqual(calc.Additional(5, 14), 20);

            Assert.DoesNotThrow(() => calc.Additional(int.MaxValue, 5));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Subtraction(40, 24), 16);
            Assert.AreEqual(calc.Subtraction(10, 25), -15);

            Assert.AreNotEqual(calc.Subtraction(10, 4), 5);

            Assert.DoesNotThrow(() => calc.Subtraction(int.MinValue, 5));
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Multiplication(4, 5), 20);
            Assert.AreEqual(calc.Multiplication(2, 0), 0);

            Assert.AreNotEqual(calc.Multiplication(4, 6), 25);

            Assert.DoesNotThrow(() => calc.Multiplication(int.MinValue, int.MaxValue));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Division(30, 3), 10);
            Assert.AreEqual(calc.Division(0, int.MaxValue), 0);
            Assert.AreEqual(calc.Division(6, 4), 1);

            Assert.AreNotEqual(calc.Division(int.MaxValue, int.MinValue), 1);

            Assert.Throws(typeof(DivideByZeroException), () => calc.Division(5, 0));
        }
    }
}

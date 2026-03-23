using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorUnitTests
    {
        private Calculator calc = null!; // Указываем компилятору, что инициализация будет

        [TestInitialize]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAdd() => Assert.AreEqual(5, calc.Add(2, 3));

        [TestMethod]
        public void TestSubtract() => Assert.AreEqual(2, calc.Subtract(5, 3));

        [TestMethod]
        public void TestMultiply() => Assert.AreEqual(6, calc.Multiply(2, 3));

        [TestMethod]
        public void TestDivide() => Assert.AreEqual(2, calc.Divide(6, 3));

        [TestMethod]
        public void TestDivideByZero()
        {
            Assert.Throws<System.DivideByZeroException>(() => calc.Divide(5, 0));
        }

        [TestMethod]
        public void TestPower() => Assert.AreEqual(8, calc.Power(2, 3));
    }
}
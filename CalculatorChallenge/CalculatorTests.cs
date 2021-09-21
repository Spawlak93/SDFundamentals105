using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorChallenge
{
    [TestClass]
    public class CalculatorTests
    {
        //create a field that is basically an ACTUAL CALCULATOR for us to use
        public Calculator calc = new Calculator();

        [TestMethod]
        public void TestSum_IntOverload_ShouldAssertExpectedAndActualAreEqual()
        {
            int expected = 10;
            int actual = calc.Sum(3, 7);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum_DoubleOverload_ShouldAssertExpectedAndActualAreEqual()
        {
            double expected = 15;
            double actual = calc.Sum(4.5d, 10.5d);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDifference_DoubleArrayOverload_ShouldAssertExpectedAndActualAreEqual()
        {
            double expected = 100d - 50d - 40d;
            double actual = calc.Difference(100d, 50d, 40d);
            Assert.AreEqual(expected, actual);
        }
    }
}

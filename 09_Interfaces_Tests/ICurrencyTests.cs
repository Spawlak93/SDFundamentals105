using _09_Interfaces_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _09_Interfaces_Tests
{
    [TestClass]
    public class ICurrencyTests
    {
        [TestMethod]
        public void PennyClassTest_ShouldReturnCorrectValue()
        {
            ICurrency penny = new Penny();

            Assert.AreEqual(0.01m, penny.Value);
        }

        [TestMethod]
        public void DimeClassTest_ShouldReturnCorrectValue()
        {
            ICurrency dime = new Dime();

            Assert.AreEqual(0.10m, dime.Value);
        }

        [TestMethod]
        public void DollarClassTest_ShouldReturnCorrectValue()
        {
            ICurrency currency = new Dollar();

            Assert.AreEqual(1m, currency.Value);
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(.01)]
        [DataRow(9000.01)]
        [DataRow(123.45)]
        public void ElectronicPaymentTest_ShouldReturnCorrectValue(double value)
        {
            decimal convertedValue = (decimal)value;

            var ePayment = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePayment.Value);
        }
    }
}

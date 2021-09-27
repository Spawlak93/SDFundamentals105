using _09_Interfaces_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _09_Interfaces_Tests
{
    [TestClass]
    public class TransactionTests
    {
        [TestMethod]
        public void TransactionConstructor_ShouldReturnCorrectValue()
        {
            Dollar dollar = new Dollar();
            var epayment = new ElectronicPayment(123.75m);
            var euro = new Euro();

            var transactionOne = new Transaction(dollar);
            var transactionTwo = new Transaction(epayment);
            var transactionThree = new Transaction(euro);

            Console.WriteLine(transactionOne.GetTransactionType());
            Console.WriteLine(transactionTwo.GetTransactionType());
            Console.WriteLine(transactionThree.GetTransactionType());

            Assert.AreEqual(1m, transactionOne.GetTransactionAmount());
            Assert.AreEqual(123.75m, transactionTwo.GetTransactionAmount());
            Assert.AreEqual(1.17m, transactionThree.GetTransactionAmount());
        }
        
    }
}

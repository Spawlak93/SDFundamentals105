using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddMethods()
        {
            //newing up a calculator object
            Calculator calculator = new Calculator();
            calculator.Add(12, 23);

                                         //Argument
            int result = calculator.Add(573, 892);
            Console.WriteLine(result);

            double sum = calculator.Add(12.5, 13.5);

            sum = calculator.Add(5, 12.8);

            int age = calculator.CalculateAge(new DateTime(1422, 11, 04));
        }
    }
}

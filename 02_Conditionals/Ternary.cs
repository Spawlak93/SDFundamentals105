using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            // (Condition/Boolean) ? ifTrueDoThis : ifFalseDoThis;

            int numberOfDucks = 10;
            string answer = (numberOfDucks > 8) ? "That is too many" : "That is far too few";

            Console.WriteLine((numberOfDucks == 12) ? "That is a dozen" : "That is not a dozen");
        }
    }
}

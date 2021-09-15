using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person = new Person();

            person.FirstName = "Bob";

            person.LastName = "Builder";

            Console.WriteLine(person.FullName);

        }
    }
}

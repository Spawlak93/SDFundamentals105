using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes_Setters
{
    [TestClass]
    public class QuackerTests
    {
        [TestMethod]
        public void InvalidUserName_ShouldThrowFormatException()
        {
            Exception thrownException = null;
            Quacker donald = new Quacker();

            //Try Catch
            try
            {
                //Tries to run any code in here
                donald.UserName = "Bob";
                Console.WriteLine("This is after setting UserName");

            }
            catch (FormatException err)
            {
                //Catches exceptions and runs code in here
                Console.WriteLine(err.Message);
                thrownException = err;
            }
            finally
            {
                //This code always runs. 
                Console.WriteLine("This code is unstoppable");
            }
            Console.WriteLine("This Code can be stopped");

            Assert.IsInstanceOfType(thrownException , typeof(FormatException));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidAge_ShouldThrowArgumentException()
        {
            var louie = new Quacker();
            louie.Age = 10;
            louie.UserName = "user";
        }
    }
}

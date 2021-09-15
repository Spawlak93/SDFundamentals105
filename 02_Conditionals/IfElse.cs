using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{

    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool isHungry = true;
               //Condition for code to run
            if(isHungry)
            {
                //Code that will run if true
                Console.WriteLine("Go get something to eat!");
            }

            int hoursSpentSleeping = 1;
            if(hoursSpentSleeping > 12)
            {
                Console.WriteLine("How do you sleep so much?");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool homeworkDone = true;
            if(homeworkDone)
            {
                Console.WriteLine("Go watch NetFlix"); 
            }
            else
            {
                Console.WriteLine("Work on that CSS creature");
            }

            int age = 15;

            if (age < 13)
            {
                Console.WriteLine("you are a child");
            }
            else if( age < 20)
            {
                Console.WriteLine("You are a teen");
                if(age >= 18)
                {
                    Console.WriteLine("You are an adult");
                }
            }
            else
            {
                Console.WriteLine("You are an adult");
            }


            if(age > 13 && age < 20)
            {
                Console.WriteLine("You are a teen");
            }
        }
    }
}

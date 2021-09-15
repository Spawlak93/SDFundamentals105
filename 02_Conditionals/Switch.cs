using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Conditionals
{
    [TestClass]  
    public class Switch
    {
        
        [TestMethod]
        public void SwitchCases()
        {
            int input = 22;

            switch(input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
                case 22:
                    Console.WriteLine("You skipped a few options");
                    break;
                default:
                    Console.WriteLine("You didnt pick any of my numbers");
                    break;
            }

            PastryType pastry = PastryType.Eclair;

            switch(pastry)
            {
                case PastryType.Cake:
                    Console.WriteLine("That is $30");
                    break;

                case PastryType.Croissant:
                case PastryType.Eclair:
                case PastryType.Cupcake:
                    Console.WriteLine("That is $4");
                    break;

            }

        }
        enum PastryType { Eclair, Croissant, PetitFour, Cake, Cupcake }
    }
}

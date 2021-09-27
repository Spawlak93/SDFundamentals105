using _09_Interfaces_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _09_Interfaces_Tests
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void TestingPeelMethod_ShouldReturnCorrectBool()
        {
            IFruit banana = new Banana();

            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The Banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInLists_ShouldGetCorrectType()
        {
            var grapefruit = new Grapefruit();

            var fruitSalad = new List<IFruit>
            {
                grapefruit,
                new Banana(),
                new Strawberry(),
                new Pear()
            };

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                //Not all IFruit can be squeezed
                //fruit.Squeeze();

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Console.WriteLine(grapefruit.Squeeze());

            Assert.IsInstanceOfType(grapefruit, typeof(Grapefruit));
        }

        private string GetNameOfFruit(IFruit fruit)
        {
            return $"This fruit is a {fruit.Name}";
        }

        [TestMethod]
        public void InterfaceInMethodParameter_ShouldReturnCorrectString()
        {
            var strawberry = new Strawberry();

            var output = GetNameOfFruit(strawberry);

            Console.WriteLine(output);
            Assert.IsTrue(output.Contains("This fruit is a Strawberry"));
        }

        [TestMethod]
        public void PatternMatchingExample_ShouldBeCorrectType()
        {
            var fruitSalad = new List<IFruit>
            {
                new Strawberry(),
                new Banana(),
                new Banana(true),
                new Grapefruit(),
                new Grapefruit(),
                new Pear(),
                new Grapefruit(true)
            };

            foreach(IFruit fruit in fruitSalad)
            {
                if(fruit is Grapefruit grapefruit)
                {
                    Console.WriteLine(fruit.Name);
                    Console.WriteLine(grapefruit.Name);
                    if(!grapefruit.IsPeeled)
                    {
                        Console.WriteLine(grapefruit.Peel());
                    }
                    else
                    {
                        Console.WriteLine("This is a GrapeFruit that is peeled");
                    }
                }
                else if(fruit.GetType() == typeof(Strawberry))
                {
                    Strawberry strawberry = (Strawberry)fruit;

                    Console.WriteLine("This is a strawberry");
                }
                else if (fruit is Pear pear)
                {
                    if (pear.IsPeeled)
                    {
                        Console.WriteLine("This is a peeled pear");
                        Console.WriteLine(pear.Peel());
                    }
                    else
                    {
                        Console.WriteLine("This is a not peeled pear");
                    }
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("This is a peeled Banana");
                }
                else
                {
                    Console.WriteLine("This is a not peeled Banana");
                }
            }
        }
    }
}

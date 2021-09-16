using _05_InheritanceClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_InheritanceTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void MovementTest_ShouldWriteToConsoleContainingAnimalTypeName()
        {
            Animal animalOne = new Animal();
            animalOne.Move();
        }

        [TestMethod]
        public void CatMovementTest_ShouldWriteToConsoleContainingCateTypeNamePlusSecondLineSpecificToCatType()
        {
            Cat catOne = new Cat();
            catOne.Move();

            catOne.ClawLength = 3.7;
        }

        [TestMethod]
        public void RagdollMethodsTest_ShouldOutputToConsoleRagdollCatSpecificWriteLines()
        {
            RagdollCat whiskers = new RagdollCat();
            Cat snickers = new RagdollCat();

            whiskers.Move();
            snickers.MakeSound();
        }
    }
}

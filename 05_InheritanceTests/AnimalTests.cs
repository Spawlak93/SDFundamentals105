using _05_InheritanceClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

        [TestMethod]
        public void CalicoConstructorTest_ShouldOutputToConsoleProperWriteLines()
        {
            Cat fluffy = new Calico();
            Cat fluffBall = new Calico(false);
        }

        [TestMethod]
        public void CheckingTypes_TypesShouldBehaveAsDeclared()
        {
            Calico catOne = new Calico();
            Animal animalOne = new Calico();

            List<Animal> animals = new List<Animal>();

            animals.Add(catOne);
            animals.Add(new RagdollCat());
            animals.Add(new Animal());
            animals.Add(new Cat());

            foreach(Animal animal in animals)
            {
                animal.Move();
            }
        }
    }
}

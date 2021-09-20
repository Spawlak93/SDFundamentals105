using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        //Arrange
        //Act
        //Assert
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //Arrange
            StreamingContent content = new StreamingContent();

            //Act
            content.Title = "Little Shop of Horrors";

            //Assert
            string expected = "Little Shop of Horrors";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);            
        }


        //Multiple data points
        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG13, false)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldGetCorrectRating(MaturityRating maturity, bool isFamilyFriendly)
        {
            //AAA
            //Arrange
            //Using loaded constructor
            StreamingContent content = new StreamingContent("Title", "Description", .5, 99, "Animation", maturity);

            //Act
            MaturityRating actualMaturity = content.RatingMaturity;
            MaturityRating expectedMaturity = maturity;

            bool actualIsFamilyFriendly = content.IsFamilyFriendly;
            bool expectedIsFamilyFriendly = isFamilyFriendly;

            //Assert
            Assert.AreEqual(expectedMaturity, actualMaturity);
            Assert.AreEqual(expectedIsFamilyFriendly, actualIsFamilyFriendly);
        }
    }
}

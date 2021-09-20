using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        //These fields were added later
        private StreamingContentRepository _repo;
        private StreamingContent _matrix;

        //TestInitialize added later
        [TestInitialize]
        public void Arrange()
        {
            _matrix = new StreamingContent("Matrix", "Mind bending scifi drama", 1.75, 8.7, "SciFi", MaturityRating.PG13);
            StreamingContent jurasicPark = new StreamingContent("Jurasic Park", "Rawr Dinosaurs", 2, 10, "SciFi", MaturityRating.PG);
            StreamingContent oldboy = new StreamingContent("Oldboy", "I dont know I havent seen this movie", 2.1, 7, "Yes", MaturityRating.R);

            _repo = new StreamingContentRepository();

            _repo.AddContentToDirectory(_matrix);
            _repo.AddContentToDirectory(jurasicPark);
            _repo.AddContentToDirectory(oldboy);
        }

        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange  --Getting what we need to run our tests. Making a book and a shelf
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act
            bool success = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(success);
        }

        //Testing READ method (GET)
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectList()
        {
            //Arrange
            StreamingContent matrix = new StreamingContent("Matrix", "Mind bending scifi drama", 1.75, 8.7, "SciFi", MaturityRating.PG13);
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(matrix);


            //Act
            List<StreamingContent> movieList = repo.GetContents();

            bool success = movieList.Contains(matrix);



            //Assert

            Assert.IsTrue(success);
        }

        [TestMethod]
        public void GetContentByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //Handled in Arrange Method

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("matrix");
            //Assert
            Assert.AreEqual(_matrix.Description, searchResult.Description);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent contentToUpdate = _repo.GetContentByTitle("Matrix");
            StreamingContent newContent = new StreamingContent("The Matrix", "An epic mindbending SciFi Drama", 1.5, 8, "SciFi", MaturityRating.PG13);

            //Act
            bool updateresult = _repo.UpdateExistingContent(contentToUpdate, newContent);

            // Assert
            Assert.IsTrue(updateresult);
        }

        [TestMethod]
        public void DeleteContentByTitle_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent contentToDelete = _repo.GetContentByTitle("oldboy");
            //Act

            bool removeResult = _repo.DeleteContent(contentToDelete);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}

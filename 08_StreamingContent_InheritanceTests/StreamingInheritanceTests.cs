using _06_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_StreamingContent_InheritanceTests
{
    [TestClass]
    public class StreamingInheritanceTests
    {
        [TestMethod]
        public void PlayingWithInheritanceNotes()
        {
            StreamingContent baseObject = new StreamingContent();
            Movie movieObject = new Movie();
            Show showObject = new Show();

            baseObject.Title = "I am a streaming content object";
            movieObject.Title = "I am a movie";
            movieObject.OscarNominations = 12;

            showObject.Title = "I am a show";
            showObject.NumberOfSeasons = 3;

            List<StreamingContent> listOfContent = new List<StreamingContent>();
            listOfContent.Add(baseObject);
            listOfContent.Add(movieObject);
            listOfContent.Add(showObject);

            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(showObject);
            repo.AddContentToDirectory(movieObject);
            repo.AddContentToDirectory(baseObject);

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine(content.Title);
                if (content is Movie movie)
                {
                    Console.WriteLine(movie.OscarNominations);
                }
                if(content is Show show)
                {
                    Console.WriteLine(show.NumberOfSeasons);
                }
            }

            MovieShowRepo movieShowRepo = new MovieShowRepo();

            movieShowRepo.AddContentToDirectory(showObject);
            movieShowRepo.AddContentToDirectory(movieObject);
            movieShowRepo.AddContentToDirectory(baseObject);
        }

        [TestMethod]
        public void GetAllShows_ShouldReturnCorrectNumberOfShows()
        {
            //Arrange
            MovieShowRepo repo = new MovieShowRepo();

            StreamingContent streamingContent = new StreamingContent();
            Movie movie = new Movie();
            Show showOne = new Show();
            Show showTwo = new Show();
            Show showThree = new Show();

            repo.AddContentToDirectory(streamingContent);
            repo.AddContentToDirectory(movie);
            repo.AddContentToDirectory(showOne);
            repo.AddContentToDirectory(showTwo);
            repo.AddContentToDirectory(showThree);

            //Act
            List<Show> actualReturn = repo.GetAllShows();
            int actualNumberOfShowsReturned = actualReturn.Count;
            int expectedNumberReturned = 3;

            //Assert
            Assert.AreEqual(expectedNumberReturned, actualNumberOfShowsReturned);

        }

        [TestMethod]
        public void GetMovieByTitle_ShouldGetCorrectMovie()
        {
            StreamingContent baseObject = new StreamingContent();
            Movie movieObject = new Movie();
            Show showObject = new Show();

            baseObject.Title = "I am a streaming content object";
            movieObject.Title = "I am a movie";
            movieObject.OscarNominations = 12;

            showObject.Title = "I am a show";
            showObject.NumberOfSeasons = 3;

            MovieShowRepo repo = new MovieShowRepo();
            repo.AddContentToDirectory(baseObject);
            repo.AddContentToDirectory(movieObject);
            repo.AddContentToDirectory(showObject);

            Movie returnedMovie = repo.GetMovieByTitle("I am a movie");

            Assert.AreEqual(movieObject.Title, returnedMovie.Title);
        }
    }
}

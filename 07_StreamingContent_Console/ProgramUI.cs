using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        public void Run()
        {
            SeedData();

            RunMenu();
        }

        private void RunMenu()
        {
            //Create a menu with options matching up to my Repository

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine
                    (
                        "Enter the number of your selection:\n" +
                        "1. Create new streaming content\n" +
                        "2. Show all streaming content\n" +
                        "3. Find streaming content by title\n" +
                        "4. Update Content by title\n" +
                        "5. Remove Content\n" +
                        "6. Exit"
                    );

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Create new Content
                        CreateNewContent();
                        break;
                    case "2":
                        //Show all Content
                        ShowAllContent();
                        break;
                    case "3":
                        //Show Content By Title
                        ShowContentTitle();
                        break;
                    case "4":
                        //Update Content
                        UpdateContent();
                        break;
                    case "5":
                        //Delete Content
                        RemoveContentFromRepository();
                        break;
                    case "6":
                        isRunning = false;
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 6.\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;

                }
            }
        }

        //Creating Content
        private void CreateNewContent()
        {
            Console.Clear();

            StreamingContent content = new StreamingContent();

            //Title
            Console.WriteLine("Please enter a title:");
            content.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Please enter a description:");
            content.Description = Console.ReadLine();

            //Runtime
            Console.WriteLine("What is the runtime of the content");
            content.RunTime = Convert.ToDouble(Console.ReadLine());

            //Review rating
            Console.WriteLine("What is the review score (0 - 10):");
            content.ReviewRating = double.Parse(Console.ReadLine());

            // Maturity Rating
            Console.WriteLine("Select a maturity rating: \n" +
                "1. G\n" +
                "2. PG\n" +
                "3. TV Y\n" +
                "4. TV Y7\n" +
                "5. PG 13\n" +
                "6. R\n" +
                "7. NC17\n" +
                "8. NR\n" +
                "9. TV MA");

            string maturityRatingString = Console.ReadLine();
            int maturityRatingId = int.Parse(maturityRatingString);
            content.RatingMaturity = (MaturityRating)maturityRatingId;

            //content.RatingMaturity = (MaturityRating)int.Parse(Console.ReadLine());

            //genre
            Console.WriteLine("what is the genre:");
            content.Genre = Console.ReadLine();

            _repo.AddContentToDirectory(content);
        }

        //Getting all Content
        private void ShowAllContent()
        {
            //Clean slate to work from
            Console.Clear();

            List<StreamingContent> listOfContent = _repo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                //Using helper method
                DisplayContent(content);
            }

            PressAnyKeyToContinue();
        }

        //Getting Specific Content(By Title)
        private void ShowContentTitle()
        {
            Console.Clear();

            Console.WriteLine("What Title are you looking for?");
            string title = Console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);
            //Verify that content is in our repository

            if (content != null)
            {
                //Using helper method
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("Unfortunatley we don't have that title");
            }

            PressAnyKeyToContinue();

        }

        //Update Content
        private void UpdateContent()
        {
            Console.Clear();

            Console.WriteLine("What is the title of the content you want to update:");
            string targetTitle = Console.ReadLine();

            StreamingContent targetContent = _repo.GetContentByTitle(targetTitle);

            if(targetContent == null)
            {
                Console.WriteLine("We are not able to find that content");
                PressAnyKeyToContinue();
                return;
            }

            StreamingContent updatedContent = new StreamingContent();

            //Title
            Console.WriteLine($"Original title: {targetContent.Title}\n" +
                $"Please enter a new title:");
            updatedContent.Title = Console.ReadLine();


            //Description
            Console.WriteLine($"Original description: {targetContent.Description}");
            Console.WriteLine("Please enter a new description:");
            updatedContent.Description = Console.ReadLine();

            //Runtime
            Console.WriteLine("Orignal Runtime: " + targetContent.RunTime + "\n" +
                "What is the new runtime of the content");
            updatedContent.RunTime = Convert.ToDouble(Console.ReadLine());

            //Review rating
            Console.WriteLine($"Original review score: {targetContent.ReviewRating}\n" +
                $"What is the new review score (0 - 10):");
            updatedContent.ReviewRating = double.Parse(Console.ReadLine());

            // Maturity Rating
            Console.WriteLine($"Original maturity rating: {targetContent.RatingMaturity}\n" +
                $"Select a new maturity rating: \n" +
                "1. G\n" +
                "2. PG\n" +
                "3. TV Y\n" +
                "4. TV Y7\n" +
                "5. PG 13\n" +
                "6. R\n" +
                "7. NC17\n" +
                "8. NR\n" +
                "9. TV MA");

            string maturityRatingString = Console.ReadLine();
            int maturityRatingId = int.Parse(maturityRatingString);
            updatedContent.RatingMaturity = (MaturityRating)maturityRatingId;

            //content.RatingMaturity = (MaturityRating)int.Parse(Console.ReadLine());

            //genre
            Console.WriteLine($"Original genre: {targetContent.Genre}\n" +
                $"What is the new genre:");
            updatedContent.Genre = Console.ReadLine();

            if(_repo.UpdateExistingContent(targetContent, updatedContent))
            {
                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Update Failed");
            }

            PressAnyKeyToContinue();
        }


        //Deleting Content
        private void RemoveContentFromRepository()
        {
            Console.Clear();

            List<StreamingContent> contentList = _repo.GetContents();

            int index = 1;

            foreach (StreamingContent content in contentList)
            {
                Console.WriteLine($"{index}. {content.Title}");
                index++;
            }

            Console.WriteLine("What title would you like to remove.");
            int targetTitleId = int.Parse(Console.ReadLine());
            int targetIndex = targetTitleId - 1;

            if(targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent targetContent = contentList[targetIndex];

                if(_repo.DeleteContent(targetContent))
                {
                    Console.WriteLine($"{targetContent.Title} was successfully deleted");
                }
                else
                {
                    Console.WriteLine("Oh no, something went wrong!");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
            }

            PressAnyKeyToContinue();
        }

        //Helper Methods
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine(
                    $"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"RunTime: {content.RunTime}\n" +
                    $"Review Score: {content.ReviewRating}\n" +
                    $"Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Maturity Rating: {content.RatingMaturity}\n" +
                    $"Genre: {content.Genre}\n\n");
        }

        private void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SeedData()
        {
            StreamingContent starwars = new StreamingContent("Star Wars", "Space Opera", 2.5, 9.3, "SciFi", MaturityRating.PG);
            StreamingContent toyStory = new StreamingContent("Toy Story", "what really goes bump in the night", 1.75, 10, "Animation", MaturityRating.G);
            StreamingContent theDuckMovie = new StreamingContent("DuckPacalypse Two: the Quackening", "Yes", 2, 9, "Horror", MaturityRating.R);

            _repo.AddContentToDirectory(starwars);
            _repo.AddContentToDirectory(toyStory);
            _repo.AddContentToDirectory(theDuckMovie);
        }
    }
}

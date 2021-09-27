using _07_StreamingContent_Console;
using _07_StreamingContent_Console.Consoles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Console_Tests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetAllContent_OutputShouldCountainCorrectTitles()
        {
            //Arrange
            //2
            //6
            List<string> commandList = new List<string> { "2", "6" };

            MockConsole console = new MockConsole(commandList);

            ProgramUI ui = new ProgramUI(console);

            //Act
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains("Space Opera"));
        }
        //Get By Title

        //Create Content
        //1
        //Title

        //Update Content


        [TestMethod]
        public void RemoveContent_ShouldNoLongerSeeRemovedContent()
        {
            //5
            //2
            //enter
            //2
            //enter
            //6
            //Arrange
            var commandList = new List<string> { "5", "2", "2", "6" };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            //Act
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsFalse(console.Output.Contains("what really goes bump in the night"));
        }
    }
}

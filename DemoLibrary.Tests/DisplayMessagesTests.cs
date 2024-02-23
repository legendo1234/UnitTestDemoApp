using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Arrange, Act, Assert
// expected and actual
namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Go to bed Matej";

            //Act
            string actual = messages.Greeting("Matej", 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good Afternoon Matej";

            //Act
            string actual = messages.Greeting("Matej", 14);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Matej",0,"Go to bed Matej")]
        [InlineData("Matej",1,"Go to bed Matej")]
        [InlineData("Matej",2,"Go to bed Matej")]
        [InlineData("Matej",3,"Go to bed Matej")]
        [InlineData("Matej",4,"Go to bed Matej")]
        [InlineData("Matej",5,"Good Morning Matej")]
        [InlineData("Matej",6,"Good Morning Matej")]
        [InlineData("Matej",7,"Good Morning Matej")]
        [InlineData("Matej",8,"Good Morning Matej")]
        [InlineData("Matej",9,"Good Morning Matej")]
        [InlineData("Matej",10,"Good Morning Matej")]
        [InlineData("Matej",11,"Good Morning Matej")]
        [InlineData("Matej",12,"Good Afternoon Matej")]
        [InlineData("Matej",13,"Good Afternoon Matej")]
        [InlineData("Matej",14,"Good Afternoon Matej")]
        [InlineData("Matej",15,"Good Afternoon Matej")]
        [InlineData("Matej",16,"Good Afternoon Matej")]
        [InlineData("Matej",17,"Good Afternoon Matej")]
        [InlineData("Matej",18,"Good Evening Matej")]
        [InlineData("Matej",19,"Good Evening Matej")]
        [InlineData("Matej",20,"Good Evening Matej")]
        [InlineData("Matej",21,"Good Evening Matej")]
        [InlineData("Matej",22,"Good Evening Matej")]
        [InlineData("Matej",23,"Good Evening Matej")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            

            //Act
            string actual = messages.Greeting(firstName,hourOfTheDay);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

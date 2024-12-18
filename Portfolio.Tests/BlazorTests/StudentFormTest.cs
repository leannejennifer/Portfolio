using System.ComponentModel.DataAnnotations;
using Bunit;
using Microsoft.AspNetCore.Components.Forms;
using Portfolio.UI.Components.Pages;
using Portfolio.UI.Models;

namespace Portfolio.Tests.BlazorTests
{
    public class StudentFormTest: Bunit.TestContext
    {
        [Test]
		public void StudentForm_NotPassedAModel_ErrorMessagesAppears()
		{
			//Arrange

			//Act
			var cut = RenderComponent<StudentForm>();
			
			var submitButton = cut.Find("input[type='submit']");

			submitButton.Click();

			var validationMessages = cut.FindAll("div.validation-message");

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(validationMessages.Any(d => d.TextContent.Contains("FirstName")));
                Assert.That(validationMessages.Any(d => d.TextContent.Contains("LastName")));
            });
        }

        [Test]
		public void StudentForm_EmptyFirstAndNotEmptyLastName_ErrorMessagesAppears()
		{
			//Arrange

			//Act
			var cut = RenderComponent<StudentForm>(
                parameters => parameters
                .Add(p=> p.Model, new() { LastName = "Chandler" })
                );

            var submitButton = cut.Find("input[type='submit']");

			submitButton.Click();

			var validationMessages = cut.FindAll("div.validation-message");

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(validationMessages.Any(d => d.TextContent.Contains("FirstName")), "First name error message not present.");
                Assert.That(!validationMessages.Any(d => d.TextContent.Contains("LastName")), "Last name error message is present but shouldn't be.");
            });
        }

        [Test]
		public void StudentForm_EmptyLastNameAndNotFirstName_ErrorMessagesAppears()
		{
			//Arrange

			//Act
			var cut = RenderComponent<StudentForm>(
                parameters => parameters
                .Add(p=> p.Model, new() { FirstName = "Leanne" })
                );

            var submitButton = cut.Find("input[type='submit']");

			submitButton.Click();

			var validationMessages = cut.FindAll("div.validation-message");

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(!validationMessages.Any(d => d.TextContent.Contains("FirstName")), "First name error message is presentbut shouldn't be.");
                Assert.That(validationMessages.Any(d => d.TextContent.Contains("LastName")), "Last name error message is not present.");
            });
        }

	}
}

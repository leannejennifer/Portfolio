using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Portfolio.UI.Components.Pages;
using Portfolio.UI.Models;
using Portfolio.UI.Services;

namespace Portfolio.Tests.BlazorTests
{
    // TestContext is a bUnit base class 
    public class StudentsTest : Bunit.TestContext
    {

        [Test]
        public void StudentsPage_NoStudents_RendersWithMessage()
        {
            // Arrange
            var mockApiService = new Mock<IApiService>();
            mockApiService.Setup(service => service.GetStudentsAsync())
                .ReturnsAsync(Enumerable.Empty<Student>());

            Services.AddSingleton(mockApiService.Object);

            // Act
            var cut = RenderComponent<Students>(parameters => parameters
                .AddCascadingValue(mockApiService.Object)); // Inject the mock

            // Assert
            cut.MarkupMatches("<h3>Students</h3><p>There are no students.</p>");
        }


    }
}

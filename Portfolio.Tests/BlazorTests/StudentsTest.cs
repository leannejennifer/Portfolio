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
        private readonly Mock<IApiService> _mockApiService;

        public StudentsTest()
        {
            _mockApiService = new Mock<IApiService>();
            Services.AddSingleton(_mockApiService.Object);
        }

        [Test]
        public void StudentsPage_NoStudents_RendersWithMessage()
        {
            // Arrange
            _mockApiService.Setup(service => service.GetStudentsAsync())
                .ReturnsAsync([]);

            // Act
            var cut = RenderComponent<Students>(parameters => parameters
                .AddCascadingValue(_mockApiService.Object)); 

            // Assert
            cut.MarkupMatches("<h3>Students</h3><p>There are no students.</p>");
        }

        [Test]

        public void StudentsPage_ThreeStudents_ReturnsThreeBulletPoints()
        {
            //Arrange
            var students = new List<Student>()
            {
                new(),
                new(),
                new(),
            };

            _mockApiService.Setup(service => service.GetStudentsAsync())
                .ReturnsAsync(students);

            //Act
            var cut = RenderComponent<Students>(parameters => parameters
                .AddCascadingValue(_mockApiService.Object));

            //Assert
            var bullets = cut.FindAll("li");
            Assert.That(bullets, Has.Count.EqualTo(3));
        }

    }
}

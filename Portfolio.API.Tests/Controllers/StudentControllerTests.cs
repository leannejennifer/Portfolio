using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using Portfolio.API.Controllers;
using Portfolio.API.Models;

namespace Portfolio.API.Tests.Controllers
{
    [TestFixture]
    public class StudentControllerTests
    {
		[Test]
		public void GetStudents_FoundInDb_ReturnsFoundList()
		{
            // Arrange
            var mockDbContext = new Mock<IDbContext>(); // Assuming you have an IDbContext interface
            var expectedStudents = new List<Student>
            {
                new() { StudentId = 1, FirstName = "Alice" },
                new() { StudentId = 2, FirstName = "Bob" }
            };
            mockDbContext.Setup(db => db.GetCollection(typeof(Student))).Returns(expectedStudents);

            var controller = new StudentController(mockDbContext.Object);

            // Act
            var result = controller.Get();

            // Assert
			Assert.That((result.Result as OkObjectResult).Value, Is.EquivalentTo(expectedStudents));

        }
        [Test]
        public void GetStudents_TypeIsNotFound_ReturnsNotFound()
        {
            //Arrange
            var mockTestContext = new Mock<IDbContext>();

            var controller = new StudentController(mockTestContext.Object);
            //Act
            var response = controller.Get();

            //Assert
            Assert.That(response.Result, Is.InstanceOf<NotFoundResult>());
        }


    }
}

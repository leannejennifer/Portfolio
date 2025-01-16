using System;
using System.Collections.Generic;
using System.Linq;
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
			//Arrange
			var dbStudents = new List<Student>()
			{
				new(){LastName = "Rogers", FirstName = "Rachel"},
				new(){LastName = "Smith", FirstName = "Jo"}
			};

            var mockStudentSet = new Mock<DbSet<Student>>(dbStudents);
            
            var mockTestContext = new Mock<SqlDbContext>();
            mockTestContext.Setup(context => context.Students).Returns(mockStudentSet.Object);

            var controller = new StudentController(mockTestContext.Object);
            //Act
            var responseStudents = controller.Get();

			//Assert
			Assert.That((responseStudents.Result as OkObjectResult).Value, Is.EquivalentTo(dbStudents));
		}
        [Test]
        public void GetStudents_TypeIsNotFound_ReturnsNotFound()
        {
            //Arrange
            var mockStudentSet = new Mock<DbSet<Student>>();

            var mockTestContext = new Mock<SqlDbContext>();
            mockTestContext.Setup(context => context.Students).Returns(mockStudentSet.Object);

            var controller = new StudentController(mockTestContext.Object);
            //Act
            var response = controller.Get();

            //Assert
            Assert.That(response.Result, Is.InstanceOf<NotFoundResult>());
        }


    }
}

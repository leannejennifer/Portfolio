using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;
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

			var mockDB = new Mock<SqlDbContext>();
			mockDB.Setup(d => d.GetCollection(typeof(Student))).Returns(dbStudents);

            var controller = new StudentController(mockDB.Object);
            //Act
            var responseStudents = controller.Get();

			//Assert
			Assert.That((responseStudents.Result as OkObjectResult).Value, Is.EquivalentTo(dbStudents));
		}
        [Test]
        public void GetStudents_TypeIsNotFound_ReturnsNotFound()
        {
            //Arrange
            var mockDBContext = new Mock<SqlDbContext>();
            mockDBContext.Setup(d => d.GetCollection(typeof(object))).Returns((IEnumerable<Student>)null);

            var controller = new StudentController(mockDBContext.Object);
            //Act
            var response = controller.Get();

            //Assert
            Assert.That(response.Result, Is.InstanceOf<NotFoundResult>());
        }


    }
}

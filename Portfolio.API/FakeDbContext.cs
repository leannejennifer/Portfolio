using Portfolio.API.Models;

namespace Portfolio.API
{
    public class FakeDbContext : IDbContext
    {
        //todo: make generic & add data layer
        public IEnumerable<Student>? GetCollection(Type type)
        {
            if (type == typeof(Student))
            {
                return Students;
            }
            return null;
                
        }
        private List<Student> Students
        {
            get
            {
                return [.. Enumerable.Range(1, 5).Select(index => new Student
                {
                    StudentId = index,
                    FirstName = "John",
                    LastName = "Smith " + index
                })];
            }
        }
    }
}

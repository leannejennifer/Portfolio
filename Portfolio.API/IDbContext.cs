using Portfolio.API.Models;

namespace Portfolio.API
{
    public interface IDbContext
    {
        public IEnumerable<Student> GetCollection(Type type);
    }
}
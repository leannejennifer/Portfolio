using Portfolio.UI.Models;

namespace Portfolio.UI.Services
{
    public interface IApiService
    {
        public Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
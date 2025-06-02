using Portfolio.UI.Models;

namespace Portfolio.UI.Services
{
    public class ApiService(HttpClient httpClient) : IApiService
    {
        private readonly HttpClient _httpClient = httpClient;

        //todo:add data layer
        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            var response = await _httpClient.GetAsync("api/Student/GetStudents");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Student>>() ?? [];
        }
    }
}

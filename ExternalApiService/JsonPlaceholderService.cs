using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace ExternalApiService
{
    public interface IJsonPlaceholderService
    {
        Task<string> GetPostsAsync();
    }

    public class JsonPlaceholderService : IJsonPlaceholderService
    {
        private readonly HttpClient _httpClient;
        public JsonPlaceholderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetPostsAsync()
        {
            var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}

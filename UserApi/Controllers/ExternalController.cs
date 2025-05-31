using ExternalApiService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExternalController : ControllerBase
    {
        private readonly IJsonPlaceholderService _service;
        public ExternalController(IJsonPlaceholderService service)
        {
            _service = service;
        }

        [HttpGet("posts")]
        public async Task<IActionResult> GetPosts()
        {
            var result = await _service.GetPostsAsync();
            return Content(result, "application/json");
        }
    }
}

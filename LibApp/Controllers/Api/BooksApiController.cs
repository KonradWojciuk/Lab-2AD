using LibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibApp.Controllers.Api
{
    [Route("api/booksapi")]
    [ApiController]
    public class BooksApiController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BooksApiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7192/Controllers/api/booksapi");
            response.EnsureSuccessStatusCode();
            var books = await response.Content.ReadFromJsonAsync<IEnumerable<Book>>();
            return Ok(books);
        }
    }
}

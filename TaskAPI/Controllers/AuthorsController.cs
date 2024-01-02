using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]

        public IActionResult GetAuthors()
        {
            var Authors = _authorRepository.GetAllAuthors();
            return Ok(Authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var Author = _authorRepository.GetAuthor(id);

            if (Author == null)
                return NotFound();
            return Ok(Author);
        }
    }
}

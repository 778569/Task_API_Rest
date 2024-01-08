using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorsController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]

        public ActionResult<ICollection<AuthorDto>> GetAuthors([FromQuery] string jobRole, string search)
        {
            var Authors = _authorRepository.GetAllAuthors(jobRole, search);


            var mapperAuthors = _mapper.Map<ICollection<AuthorDto>>(Authors);
            //foreach (var item in Authors)
            //{
            //    AuthorsDto.Add(new AuthorDto
            //    {
            //        Id = item.Id,
            //        FullName= item.FullName,
            //        Address = item.AddressNo + " , "+  item.Street + " , " + item.City,
            //    });
            //}
            return Ok(mapperAuthors);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetAuthor(int id)
        {
            var Author = _authorRepository.GetAuthor(id);


            if (Author == null)
                return NotFound();

            var mappedAuthor = _mapper.Map<AuthorDto>(Author);


            return Ok(mappedAuthor);
        }

        [HttpPost]

        public ActionResult<AuthorDto> CreateAuthor(CreateAuthorDto createAuthorDto)
        {


            var authorEntity = _mapper.Map<Author>(createAuthorDto);

            var newAuthor = _authorRepository.CreateAuthor(authorEntity);

            var AuthorForReturn = _mapper.Map<AuthorDto>(newAuthor);

            return CreatedAtRoute("GetAuthor", new { id = AuthorForReturn.Id }, AuthorForReturn);


        }
    }
}
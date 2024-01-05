using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorid}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        //private readonly TodoService _todoService;
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository todoRepository, IMapper mapper)
        {
            
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        [HttpGet]

        public ActionResult<ICollection<TodoDto>> GetTodos(int authorid)
        {

            //var Mytodos = _todoRepository.AllTodos();

            //if (id == null)
            //{
            //    return Ok(Mytodos);
            //}
            //Mytodos = Mytodos.Where(i => i.ID == id).ToList();

            //return Ok(Mytodos);

            var Mytodos = _todoRepository.AllTodos(authorid);

            //if (id == null)
            //{
            //    return Ok(Mytodos);
            //}
            //Mytodos = Mytodos.Where(i => i.ID == id).ToList();

            var mapTodos = _mapper.Map<ICollection<TodoDto>>(Mytodos);

            return Ok(mapTodos);
        }

        [HttpGet("{id?}")]

        public IActionResult GetTodo(int authorid , int id)
        {
            var todo = _todoRepository.GetTodo(authorid, id);

            if (todo is null)
                return NotFound();

            var mapTodo = _mapper.Map<TodoDto>(todo);

            return Ok(mapTodo);
        }
    }
}

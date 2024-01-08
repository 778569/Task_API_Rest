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

        [HttpGet("{id?}", Name ="GetTodo")]

        public IActionResult GetTodo(int authorid , int id)
        {
            var todo = _todoRepository.GetTodo(authorid, id);

            if (todo is null)
                return NotFound();

            var mapTodo = _mapper.Map<TodoDto>(todo);

            return Ok(mapTodo);
        }


        [HttpPost]

        public ActionResult<Todo> CreateTodo(int authorid , CreateTodoDto createTodoDto)
        {
            var beforemap = _mapper.Map<Todo>(createTodoDto);

            var ReturnTodo = _todoRepository.CreateTodo(authorid, beforemap);

            var AfterMap = _mapper.Map<TodoDto>(ReturnTodo);

            return CreatedAtRoute("GetTodo", new {authorid = authorid, id= AfterMap.ID}, AfterMap);
        }

        [HttpPut("{todoId}")]

        public IActionResult UpdateTodo(int authorid, int todoId ,UpdateTodoDto updateTodoDto)
        {

            var updatingTodo = _todoRepository.GetTodo(authorid, todoId);

            if (updatingTodo is null)
            {
                return NotFound();
            }

            _mapper.Map(updateTodoDto, updatingTodo);
            _todoRepository.UpdateTodo(updatingTodo);

            return NoContent();
        }


        [HttpDelete("{todoId}")]

        public ActionResult DeleteTodo(int authorId, int todoId)
        {
            var deleteTodo = _todoRepository.GetTodo(authorId,todoId);

            if (deleteTodo == null)
            {
                return NotFound();
            }

            _todoRepository.DeleteTodo(deleteTodo);

            return NoContent();
        }
    }
}

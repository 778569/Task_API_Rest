using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        //private readonly TodoService _todoService;
        private readonly ITodoRepository _todoRepository;

        public TodosController(ITodoRepository todoRepository)
        {
            
            _todoRepository = todoRepository;
        }

        [HttpGet]

        public IActionResult GetTodos()
        {

            //var Mytodos = _todoRepository.AllTodos();

            //if (id == null)
            //{
            //    return Ok(Mytodos);
            //}
            //Mytodos = Mytodos.Where(i => i.ID == id).ToList();

            //return Ok(Mytodos);

            var Mytodos = _todoRepository.AllTodos();

            //if (id == null)
            //{
            //    return Ok(Mytodos);
            //}
            //Mytodos = Mytodos.Where(i => i.ID == id).ToList();

            return Ok(Mytodos);
        }

        [HttpGet("{id?}")]

        public IActionResult GetTodo(int id)
        {
            var todo = _todoRepository.GetTodo(id);

            if (todo is null)
                return NotFound();
            return Ok(todo);
        }
    }
}

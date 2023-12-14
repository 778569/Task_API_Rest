using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly TodoService _todoService;
        private readonly ITodoRepository _todoRepository;

        public TodosController(ITodoRepository todoRepository)
        {
            
            _todoRepository = todoRepository;
        }

        [HttpGet("{id?}")]

        public IActionResult GetTodos(int? id)
        {

            //var Mytodos = _todoRepository.AllTodos();

            //if (id == null)
            //{
            //    return Ok(Mytodos);
            //}
            //Mytodos = Mytodos.Where(i => i.ID == id).ToList();

            //return Ok(Mytodos);

            var Mytodos = _todoRepository.AllTodos_Data();

            if (id == null)
            {
                return Ok(Mytodos);
            }
            Mytodos = Mytodos.Where(i => i.ID == id).ToList();

            return Ok(Mytodos);
        }

        //[HttpGet]

        
    }
}

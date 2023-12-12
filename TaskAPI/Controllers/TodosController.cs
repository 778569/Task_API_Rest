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

        public TodosController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("{id?}")]

        public IActionResult GetTodos(int? id)
        {

            var Mytodos = _todoService.AllTodos();

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

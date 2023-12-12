using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        [HttpGet]
        public IActionResult Task()
        {
            var tasks = new string[] { "Task 01", "Task 02", "Task 03" };
            return Ok(tasks);
        }


        [HttpPost]

        public IActionResult NowTask()
        {
            return Ok();
        }

        [HttpPut]

        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]

        public IActionResult DeleteTask()
        {
            //return Ok();

            var something = true;
            if (something)
            {
                return BadRequest();
            }
            return Ok();
        }










        //[HttpGet]

        //public IActionResult Get()
        //{
        //    //var data = new string[] { "Task 01" , "Task 02" , "Task 03"};

        //    //return Ok(data);

        //    //var data = new string[] { };

        //    //string? data = null;

        //    //if (data == null)
        //    //{
        //    //    return Unauthorized();
        //    //}
        //    //return Ok(data);

        //    return new StatusCodeResult(403);
        //}



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoSQLService : ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            throw new NotImplementedException();
        }

        public List<Todo> AllTodos_Data() 
        {
            var todos = new List<Todo>();

            var todo1 = new Todo()
            {
                ID = 4,
                Title = "Meka karapan",
                Description = "School yaman, Poth ganin",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);
            var todo2 = new Todo()
            {
                ID = 5,
                Title = "Elawalu oni",
                Description = "Polata yaman, Ganin",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed
            };
            todos.Add(todo2);
            var todo3 = new Todo()
            {
                ID = 6,
                Title = "Prathuru oni",
                Description = "Market ekan ganin",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo3);
            return todos;
        }
    }
}

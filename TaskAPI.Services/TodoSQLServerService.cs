using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoSQLServerService : ITodoRepository
    {
        private readonly TodoDbContext _todoDbContext;

        public TodoSQLServerService(TodoDbContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
        }

        public List<Todo> AllTodos()
        {
           return _todoDbContext.Todos.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoSQLServerService : ITodoRepository
    {
        private readonly TodoDbContext _todoDbContext;

        public TodoSQLServerService(TodoDbContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
        }

        public List<Todo> AllTodos(int authorid)
        {
            return _todoDbContext.Todos.Where(t => t.AuthorId == authorid).ToList();
        }

        public Todo? GetTodo(int authorid , int id)
        {
            return _todoDbContext.Todos.FirstOrDefault(t=> t.AuthorId == authorid && t.ID == id);
        }
    }
}

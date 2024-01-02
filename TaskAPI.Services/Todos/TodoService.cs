using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo()
            {
                ID = 1,
                Title = "Get Books for the school",
                Description = "You need to get your book",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);
            var todo2 = new Todo()
            {
                ID = 2,
                Title = "Get Vegitable",
                Description = "Go to Fair and buy vegitables",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed
            };
            todos.Add(todo2);
            var todo3 = new Todo()
            {
                ID = 3,
                Title = "Get Fruit",
                Description = "Go to market and Buy Fruit",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo3);
            return todos;
        }

        public Todo GetTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}

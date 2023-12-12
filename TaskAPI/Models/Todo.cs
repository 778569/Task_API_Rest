using System.Reflection.PortableExecutable;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int ID { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime Created{ get; set; }

        public DateTime Due { get; set; }

        public TodoStatus Status { get; set; }
    }
}

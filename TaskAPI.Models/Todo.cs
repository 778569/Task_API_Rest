using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Title { get; set; }

        [MaxLength(300)]

        public string? Description { get; set; }
        [Required]
        public DateTime Created{ get; set; }
        [Required]

        public DateTime Due { get; set; }
        [Required]
        public TodoStatus Status { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}

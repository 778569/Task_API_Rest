using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStraing = "Server=DESKTOP-0D8DMT4;Initial Catalog=MyTodoDBase;Integrated Security=true; User Id=sa;password =778569119119; MultipleActiveResultSets=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionStraing);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Todo>().HasData (
                new Todo
                {
                    ID = 1,
                    Title = "Get Books for the school",
                    Description = "You need to get your book",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New

                });
            
        }
    }
}

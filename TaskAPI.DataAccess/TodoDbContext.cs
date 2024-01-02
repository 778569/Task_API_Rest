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

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStraing = "Server=DESKTOP-0D8DMT4;Initial Catalog=MyTodoDataBase;Integrated Security=true; User Id=sa;password =778569119119; MultipleActiveResultSets=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionStraing);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author[]
                {
                 new Author { Id = 1, FullName = "Kavinda Bandara"},
                 new Author { Id = 2, FullName = "Shakuni Samanmalee"},
                 new Author { Id = 3, FullName = "Sam Don Karunarathne"},
                 new Author { Id = 4, FullName = "Harshana Disanayake"}
                });


           modelBuilder.Entity<Todo>().HasData (
                new Todo[]
                {
                    new Todo
                    {
                    ID = 1,
                    Title = "Get Books for the school",
                    Description = "You need to get your book",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                    },


                    new Todo
                    {
                    ID = 2,
                    Title = "Need to Vegitable - DB",
                    Description = "You need to Super market",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                    },

                    new Todo
                    {
                    ID = 3,
                    Title = "Need to Camera - DB",
                    Description = "You need to go to Studio",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 2
                    }


                });
            
        }
    }
}

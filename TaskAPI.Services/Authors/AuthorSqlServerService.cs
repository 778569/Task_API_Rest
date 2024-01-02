using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDbContext _todoDbContext;


        public AuthorSqlServerService(TodoDbContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
        }
        public List<Author> GetAllAuthors()
        {
            return _todoDbContext.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _todoDbContext.Authors.Find(id);

        }
    }
}

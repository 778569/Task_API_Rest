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

        public List<Author> GetAllAuthors(string JobRole, string search)
        {
            if (string.IsNullOrEmpty(JobRole) && string.IsNullOrEmpty(search))
            {
               return GetAllAuthors();
            }


            var authorCollection = _todoDbContext.Authors as IQueryable<Author>;


            if (!string.IsNullOrEmpty(JobRole))
            {
                JobRole = JobRole.Trim();
                authorCollection = authorCollection.Where(a => a.JobRole == JobRole);
            }

            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(a => a.FullName.Contains(search) || a.City.Contains(search));
            }

            return authorCollection.ToList();
            //return _todoDbContext.Authors.Where(a => a.JobRole == JobRole).ToList();
        }

        public Author GetAuthor(int id)
        {
            return _todoDbContext.Authors.Find(id);

        }


        public Author CreateAuthor(Author Author)
        {
            _todoDbContext.Authors.Add(Author);
            _todoDbContext.SaveChanges();

            return _todoDbContext.Authors.Find(Author.Id);
        }

    }
}

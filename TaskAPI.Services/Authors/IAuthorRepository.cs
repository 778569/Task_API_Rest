using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Models;

namespace TaskAPI.Services.Authors
{
    public interface IAuthorRepository
    {

        public List<Author> GetAllAuthors();

        public List<Author> GetAllAuthors(string JobRole, string search);

        public Author GetAuthor(int id);

        public Author CreateAuthor(Author Author);

    }
}

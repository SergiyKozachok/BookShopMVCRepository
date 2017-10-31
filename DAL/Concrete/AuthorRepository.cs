using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Concrete
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IEFContext _context;

        public AuthorRepository(IEFContext context)
        {
            _context = context;
        }

        public Author Add(Author author)
        {
            _context.Set<Author>().Add(author);
            return author;
        }

        public void Delete(int id)
        {
            var author = this.GetAuthorById(id);
            if(author != null)
            {
                _context.Set<Author>().Remove(author);
                this.SaveChange();
            }
        }

        public void Dispose()
        {
            if (this._context != null)
                this._context.Dispose();
        }

        public IQueryable<Author> GetAllAuthors()
        {
            return this._context.Set<Author>();
        }

        public Author GetAuthorById(int id)
        {
            return this.GetAllAuthors()
                .SingleOrDefault(c => c.Id == id);
        }

        public void SaveChange()
        {
            this._context.SaveChanges();
        }
    }
}

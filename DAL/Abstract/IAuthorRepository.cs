﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IAuthorRepository : IDisposable
    {
        Author Add(Author author);
        IQueryable<Author> GetAllAuthors();
        void Delete(int id);
        Author GetAuthorById(int id);
        void SaveChange();
    }
}

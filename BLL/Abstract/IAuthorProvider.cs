using BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IAuthorProvider
    {
        int AddAuthor(AddAuthorViewModel addAuthor);
        IEnumerable<AuthorItemViewModel> GetAuthors();
        void Delete(int id);
        EditAuthorViewModel EditAuthor(int id);
        int EditAuthor(EditAuthorViewModel editAuthor);
        AuthorItemViewModel GetAuthorInfo(int id);

    }
}

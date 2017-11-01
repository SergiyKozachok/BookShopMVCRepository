using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.ViewModels.AccountViewModel;

namespace BLL.Abstract
{
    public interface IAccountProvider
    {
        StatusAccountViewModel Register(RegisterViewModel model);
        StatusAccountViewModel Login(LoginViewModel model);
        IEnumerable<string> UserRoles(string email);
        void Logout();
    }
}

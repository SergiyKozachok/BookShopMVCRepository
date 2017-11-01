using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IRoleRepository
    {
        Role Add(Role role);
        IQueryable<Role> GetAllRoles();
        Role GetRoleByName(string name);
        Role GetRoleById(int id);
        void SaveChange();
    }
}

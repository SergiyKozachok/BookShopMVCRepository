using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class EFContext : DbContext, IEFContext
    {
        public EFContext() : base("BookShopConnection")
        {
            Database.SetInitializer<EFContext>(null);
        }

        public EFContext(string connString) : base(connString)
        {
            Database.SetInitializer<EFContext>(new DBInitializer());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        IDbSet<TEntity> IEFContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }
    }
}

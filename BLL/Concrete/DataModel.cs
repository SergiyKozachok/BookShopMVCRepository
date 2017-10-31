using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DAL.Entity;
using DAL.Abstract;
using DAL.Concrete;
using BLL.Abstract;

namespace BLL.Concrete
{
    public class DataModel : Autofac.Module
    {
        private string _connString;

        public DataModel(string connString)
        {
            _connString = connString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new EFContext(this._connString))
                .As<IEFContext>().InstancePerRequest();
            builder.RegisterType<AuthorRepository>()
                .As<IAuthorRepository>().InstancePerRequest();
            builder.RegisterType<AuthorProvider>()
                .As<IAuthorProvider>().InstancePerRequest();
            base.Load(builder);
        }
    }
}

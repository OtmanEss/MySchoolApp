using School.Core.Interfaces;
using School.Core.Models;
using School.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Repository
{
    public class SqlRepository<T> : IRepository<T> where T : BaseClass
    {
        SchoolContext context;
        DbSet<T> dbset;

        public SqlRepository(SchoolContext context)
        {
            this.context = context;
            this.dbset = context.Set<T>();
        }

        public void AddNew(T objet)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Collection()
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Details(T objet)
        {
            throw new NotImplementedException();
        }

        public T FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T objet)
        {
            throw new NotImplementedException();
        }
    }
}

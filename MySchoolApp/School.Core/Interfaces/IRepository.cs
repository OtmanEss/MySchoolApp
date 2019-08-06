using School.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Interfaces
{
    public interface IRepository<T> where T:BaseClass
    {
        IQueryable<T> Collection();
        void Save();
        void AddNew(T objet);
        bool Delete(string id);
        void Update(T objet);
        T FindById(string id);
        void Details(T objet);
    }
}

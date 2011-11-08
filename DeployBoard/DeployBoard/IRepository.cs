using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeployBoard
{
    interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        T GetById(long id);
        T Get(Func<T, Boolean> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Func<T, bool> where);
    }
}

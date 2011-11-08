using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeployBoard.Models
{
    public abstract class RepositoryBase<T> where T : class
    {
        private MyDeployBoardContext _dataContext;
        private readonly IDbSet<T> _dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = new databaseFactory();
            _dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get; private set; 
        }

        protected MyDeployBoardContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
            set { throw new NotImplementedException(); }
        }

        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual T GetById(long id);
    }

    public interface IDatabaseFactory
    {
    }
}
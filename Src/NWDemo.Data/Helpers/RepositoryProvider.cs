using System;
using System.Collections.Generic;
using System.Data.Entity;
using NWDemo.Data.Contracts;

namespace NWDemo.Data.Helpers
{
    public class RepositoryProvider : IRepositoryProvider
    {
        public RepositoryProvider(RepositoryFactories repositoryFactories)
        {
            _repositoryFactories = repositoryFactories;
            Repositories = new Dictionary<Type, object>();
        }

        public DbContext DbContext
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IRepository<T> GetRepositoryForEntityType<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public T GetRepository<T>(Func<DbContext, object> factory = null) where T : class
        {
            throw new NotImplementedException();
        }

        public void SetRepository<T>(T repository)
        {
            throw new NotImplementedException();
        }
        protected Dictionary<Type, object> Repositories { get; private set; }
        private RepositoryFactories _repositoryFactories;
    }
}

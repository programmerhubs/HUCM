using System;
using Microsoft.EntityFrameworkCore;

namespace HUCM_App.GenricRepostiory
{
	public class UnitOfWork:IUnitOfWork
	{
        private readonly DbContext _context;
        private readonly Dictionary<string, object> _repositories = new();

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            var typeName = typeof(T).Name;
            if (!_repositories.ContainsKey(typeName))
            {
                var repositoryInstance = new Repository<T>(_context);
                _repositories.Add(typeName, repositoryInstance);
            }

            return (IRepository<T>)_repositories[typeName];
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}


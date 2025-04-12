using System;
namespace HUCM_App.GenricRepostiory
{
	public interface IUnitOfWork
	{
        IRepository<T> Repository<T>() where T : class;
        int Complete();
    }
}


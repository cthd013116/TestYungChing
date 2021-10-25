using System;

namespace ApiProject.Repositories
{
    public interface IEmployee : IDisposable
	{
		IRepository<T> Repository<T>() where T : class;

		void Save();

		//void Dispose();

		IDatabaseTransaction BeginTransaction();
	}
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace ApiProject.Repositories
{
	public class EntityDatabaseTransaction : IDatabaseTransaction
	{
		private IDbContextTransaction _tran;


		public EntityDatabaseTransaction(DbContext context)
		{
			_tran = context.Database.BeginTransaction();
		}

		public void Commit()
		{
			_tran.Commit();
		}

		public void Dispose()
		{
			_tran.Dispose();
		}

		public void Rollback()
		{
			_tran.Rollback();
		}
	}
}

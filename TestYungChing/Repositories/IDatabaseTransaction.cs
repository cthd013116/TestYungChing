using System;

namespace ApiProject.Repositories
{
	public interface IDatabaseTransaction : IDisposable
	{
		void Commit();

		void Rollback();
	}
}

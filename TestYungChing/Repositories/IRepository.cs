using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ApiProject.Repositories
{
    public interface IRepository<T>
	{
		IQueryable<T> GetAll();

		void Insert(T entity);

		void Update(T entity);

		void Delete(T entity);

		void Delete(IList<T> entitys);

		//void Save();
		IQueryable<T> Find(Expression<Func<T, bool>> expression);
	}
}

using Architecture.UnitOfWork.Context;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Architecture.UnitOfWork.GenericRepository
{
	public class GenericRepository<T> : IRepository<T> where T : class
	{
		private readonly MyDbContext _dbContext;

		private DbSet<T> _dbSet => _dbContext.Set<T>();

		public IQueryable<T> Entities => _dbSet;

		public GenericRepository(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Remove(T entity)
		{
			_dbSet.Remove(entity);
		}

		public void Add(T entity)
		{
			_dbSet.Add(entity);
		}
	}
}

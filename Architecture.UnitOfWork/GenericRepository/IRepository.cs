using System.Linq;

namespace Architecture.UnitOfWork.GenericRepository
{
	public interface IRepository<T> where T : class
	{
		IQueryable<T> Entities { get; }
		void Remove(T entity);
		void Add(T entity);
	}
}

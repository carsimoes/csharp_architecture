using Architecture.UnitOfWork.Entities;
using Architecture.UnitOfWork.GenericRepository;

namespace Architecture.UnitOfWork.UOW
{
	public interface IUnitOfWork
	{
		IRepository<Author> AuthorRepository { get; }
		IRepository<Book> BookRepository { get; }

		/// <summary>
		/// Commits all changes
		/// </summary>
		void Commit();

		/// <summary>
		/// Discards all changes that has not been commited
		/// </summary>
		void RejectChanges();

		void Dispose();
	}
}

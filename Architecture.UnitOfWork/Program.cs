using Architecture.UnitOfWork.Context;
using Architecture.UnitOfWork.Entities;
using Architecture.UnitOfWork.UOW;
using System.Linq;

namespace Architecture.UnitOfWork
{
	class Program
	{
		private readonly IUnitOfWork uow;

		public Program()
		{

		}

		static void Main(string[] args)
		{
			var dbContext = new MyDbContext("{connectionString goes here}");
			var unitOfWork = new UOW.UnitOfWork(dbContext);

			var books = unitOfWork.BookRepository.Entities.Where(n => n.Title == "Hello World");
			var justOneBook = unitOfWork.BookRepository.Entities.First(n => n.ID == 1);

			//Create
			var author = new Author() { Name = "Kris" };
			unitOfWork.AuthorRepository.Add(author);
			unitOfWork.Commit();

			//Update
			author = unitOfWork.AuthorRepository.Entities.First(n => n.Name == "Kris");
			author.Name = "Dan";
			unitOfWork.Commit();

			// Delete
			author = unitOfWork.AuthorRepository.Entities.First(n => n.Name == "Dan");
			unitOfWork.AuthorRepository.Remove(author);
			unitOfWork.Commit();

			// Delete
			author = unitOfWork.AuthorRepository.Entities.First(n => n.Name == "Dan");
			unitOfWork.AuthorRepository.Remove(author);
			unitOfWork.RejectChanges();

		}
	}
}

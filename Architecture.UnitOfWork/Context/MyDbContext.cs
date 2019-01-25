using Architecture.UnitOfWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace Architecture.UnitOfWork.Context
{
	public class MyDbContext : DbContext
	{
		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Book> Books { get; set; }

		public MyDbContext(string nameOrConnectionString)
		//		: base(nameOrConnectionString)
		{
		}
	}
}

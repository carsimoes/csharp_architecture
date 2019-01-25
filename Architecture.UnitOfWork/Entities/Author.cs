using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Architecture.UnitOfWork.Entities
{
	[Table("Authors")]
	public class Author
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Book> Books { get; set; }
	}
}

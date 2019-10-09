using System.Collections.Generic;

namespace Architecture.DI.Ioc.Services
{
	public class PersonService : IPersonService
	{
		public List<Person> GetPeople()
		{
			return new List<Person>() { new Person() { FirstName = "Jobs" } };
		}
	}
}

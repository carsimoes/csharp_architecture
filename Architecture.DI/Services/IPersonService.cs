using System.Collections.Generic;

namespace Architecture.DI.Ioc.Services
{
	public interface IPersonService
	{
		List<Person> GetPeople();
	}
}

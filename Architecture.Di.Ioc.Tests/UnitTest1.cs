using Architecture.Di.Ioc.Unity;
using Architecture.DI.Ioc.Services;
using Xunit;

namespace Architecture.Di.Ioc.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void UnityTest()
		{
			Bootstrapper.Init();
			var personService = DependencyInjector.Retrieve<PersonService>();
			var persons = personService.GetPeople();
		}
	}
}

using Architecture.DesignPatterns.Structural.Facade.CarFacade;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class CarFacedeTests
	{
		[Fact]
		public void CarFacedePraticalTests()
		{
			CarFacade facade = new CarFacade();
			
			Assert.True(facade.CreateCompleteCar());
		}
	}
}

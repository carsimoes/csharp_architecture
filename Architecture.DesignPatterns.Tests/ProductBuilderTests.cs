using Architecture.DesignPatterns.Creational.Builder.ProductBuilder;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class ProductBuilderTests
	{
		[Fact]
		public void SimpleTest()
		{
			bool pass = true;
			try
			{
				Builder builder = new ConcreteBuilder();
				Director director = new Director(builder);

				Client client = new Client();
				client.ClientCode(director, builder);
			}
			catch
			{
				pass = false;
			}

			Assert.True(pass);
		}
	}
}

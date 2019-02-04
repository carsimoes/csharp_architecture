using Architecture.DesignPatterns.Structural.Adapter.SimpleExample;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class SimpleAdapterTests
	{
		[Fact]
		public void SimpleTest()
		{
			bool pass = true;
			try
			{
				Adaptee adaptee = new Adaptee();
				ITarget target = new Adapter(adaptee);

				//"Adaptee interface is incompatible with the client."
				//"But with adapter client can call it's method."

				target.GetRequest();
				//Console.WriteLine(target.GetRequest());
			}
			catch
			{
				pass = false;
			}

			Assert.True(pass);
		}
	}
}

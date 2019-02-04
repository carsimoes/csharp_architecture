using Architecture.DesignPatterns.Behavioral.Command.SimpleExample;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class SimpleCommandTests
	{
		[Fact]
		public void SimpleTest()
		{
			bool pass = true;
			try
			{
				Invoker invoker = new Invoker();
				invoker.SetOnStart(new SimpleCommand("Say Hi!"));

				Receiver r = new Receiver();
				invoker.SetOnFinish(new ComplexCommand(r, "Send email", "Save report"));

				invoker.DoSomethingImportant();
			}
			catch
			{
				pass = false;
			}

			Assert.True(pass);
		}
	}
}

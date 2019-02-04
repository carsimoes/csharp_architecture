using Architecture.DesignPatterns.Structural.Proxy.ClientProxy;
using System;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class ClientProxyTests
	{
		[Fact]
		public void SimpleTest()
		{
			bool pass = true;
			try
			{
				ProxyClient proxy = new ProxyClient();
				Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());
			}
			catch
			{
				pass = false;
			}

			Assert.True(pass);
		}
	}
}

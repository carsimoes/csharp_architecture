using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Structural.Proxy.ClientProxy
{
	/// <summary>
	/// The 'Proxy Object' class
	/// </summary>
	public class ProxyClient : IClient
	{
		RealClient client = new RealClient();

		public ProxyClient()
		{
			Console.WriteLine("ProxyClient: Initialized");
		}

		public string GetData()
		{
			return client.GetData();
		}
	}
}

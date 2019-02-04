using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Structural.Proxy.ClientProxy
{
	/// <summary>
	/// The 'RealSubject' class
	/// </summary>
	public class RealClient : IClient
	{
		string Data;

		public RealClient()
		{
			Console.WriteLine("Real Client: Initialized");
			Data = "Sample data";
		}

		public string GetData()
		{
			return Data;
		}
	}
}

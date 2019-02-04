using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Behavioral.Command.SimpleExample
{
	public class Receiver
	{
		public void DoSomething(string a)
		{
			Console.Write("Receiver: Working on (" + a + ".)\n");
		}

		public void DoSomethingElse(string b)
		{
			Console.Write("Receiver: Also working on (" + b + ".)\n");
		}
	}
}

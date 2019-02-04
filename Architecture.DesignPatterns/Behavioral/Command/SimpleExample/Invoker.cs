using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Behavioral.Command.SimpleExample
{
	public class Invoker
	{
		Command onStart;

		Command onFinish;

		public void SetOnStart(Command c)
		{
			onStart = c;
		}

		public void SetOnFinish(Command c)
		{
			onFinish = c;
		}

		public void DoSomethingImportant()
		{
			Console.Write("Invoker: Does anybody want something done before I begin?\n");
			if (onStart is Command)
			{
				onStart.Execute();
			}
			Console.Write("Invoker: ...doing something really important...\n");
			Console.Write("Invoker: Does anybody want something done after I finish?\n");
			if (onFinish is Command)
			{
				onFinish.Execute();
			}
		}
	}
}

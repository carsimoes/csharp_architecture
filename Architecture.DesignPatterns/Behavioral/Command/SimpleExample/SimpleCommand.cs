using System;

namespace Architecture.DesignPatterns.Behavioral.Command.SimpleExample
{
	public class SimpleCommand : Command
	{
		string _phrase = string.Empty;

		public SimpleCommand(string something)
		{
			_phrase = something;
		}

		public override void Execute()
		{
			Console.Write($"SimpleCommand: See, I can do simple things like this ({_phrase})\n");
		}
	}
}

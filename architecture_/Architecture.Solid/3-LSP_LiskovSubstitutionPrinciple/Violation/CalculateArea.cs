using System;

namespace Architecture.Solid.LSP.Violation
{
	public class CalculateArea
	{
		private static void RectangleArea(Rectangle ret)
		{
			Console.Clear();
			Console.WriteLine("Calc...");
			Console.WriteLine();
			Console.WriteLine(ret.Height + " * " + ret.Width);
			Console.WriteLine();
			Console.WriteLine(ret.Area);
			Console.ReadKey();
		}

		public static void Execute()
		{
			var Square = new Square()
			{
				Height = 10,
				Width = 5
			};

			RectangleArea(Square);
		}
	}
}

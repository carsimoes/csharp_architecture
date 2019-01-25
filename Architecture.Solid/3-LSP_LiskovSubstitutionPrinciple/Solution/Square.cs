using System;

namespace Architecture.Solid.LSP.Solution
{
	public class Square : Parallelogram
	{
		public Square(int height, int width)
							: base(height, width)
		{
			if (width != height)
				throw new ArgumentException("ex");
		}
	}
}

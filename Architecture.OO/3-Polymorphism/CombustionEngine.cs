namespace Architecture.OO
{
	public class CombustionEngine : Engine
	{
		public CombustionEngine(string name, int voltage)
				: base(name, voltage)
		{

		}

		public CombustionEngine()
				: base("Default", 220)
		{

		}

		private static void PistonMove()
		{

		}

		private static void Ignition()
		{

		}

		public void BeginEngine()
		{
			Ignition();
			PistonMove();
			// ETC...
		}

		public override void On()
		{
			//..
		}

		public override void Off()
		{
			//..
		}
	}
}

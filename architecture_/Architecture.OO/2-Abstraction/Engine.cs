namespace Architecture.OO
{
	public abstract class Engine
	{
		private readonly string _name;
		private readonly int _voltage;

		protected Engine(string name, int voltage)
		{
			_name = name;
			_voltage = voltage;
		}

		public abstract void On();

		public abstract void Off();
	}
}

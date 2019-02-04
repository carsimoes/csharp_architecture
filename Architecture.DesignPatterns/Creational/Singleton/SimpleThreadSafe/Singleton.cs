using System;

namespace Architecture.DesignPatterns.Creational.Singleton.SimpleThreadSafe
{
	public sealed class Singleton
	{
		private static Singleton _instance = null;

		private static readonly object objLock = new object(); 

		private int _counter = 0;

		private Singleton() { }

		public static Singleton Instance
		{
			get
			{
				lock (objLock)  // Added new block
				{
					if (_instance == null)
						_instance = new Singleton();

					return _instance;
				}
			}
		}

		public int Increament()
		{
			return _counter++;
		}

		public void Print()
		{
			Console.WriteLine("Counter Value: " + _counter.ToString());
		}
	}
}

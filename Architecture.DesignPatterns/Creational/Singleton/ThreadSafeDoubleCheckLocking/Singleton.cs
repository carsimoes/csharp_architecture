using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Creational.Singleton.ThreadSafeDoubleCheckLocking
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
				if (_instance == null)
				{
					lock (objLock)
					{
						if (_instance == null)
							_instance = new Singleton();
					}
				}
				return _instance;
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

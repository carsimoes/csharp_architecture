using System;
using System.Collections.Generic;

namespace Architecture.DesignPatterns.Creational.Singleton.Classic
{
	public sealed class Bird
	{
		private static Bird _BirdInstance;

		private static Queue<string> _Food = new Queue<string>();
 
		private Bird() { }

		public static Bird GetBirdInstance(string instanceName)
		{
			//If there is no instance of printer class exists then instantiate   
			if (_BirdInstance == null)
			{
				Console.WriteLine("{0} Bird created", instanceName);
				_BirdInstance = new Bird();
			}

			return _BirdInstance;
		}
	}
}

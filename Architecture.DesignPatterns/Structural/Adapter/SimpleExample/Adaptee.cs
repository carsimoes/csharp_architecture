using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Structural.Adapter.SimpleExample
{
	public class Adaptee
	{
		public string GetSpecificRequest()
		{
			return "Specific request.";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Behavioral.Response
{
	public abstract class Base
	{
		public bool Success { get; protected set; }

		public string DescriptionMessage { get; protected set; }

		public Exception InternalException { get; protected set; }

		public Base(bool success, string descriptionMessage, Exception internalException)
		{
			Success = success;
			DescriptionMessage = descriptionMessage;
			InternalException = internalException;
		}
	}
}

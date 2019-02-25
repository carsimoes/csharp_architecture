using System;

namespace Architecture.DesignPatterns.Behavioral.Response
{
	public class Response<T> : Base
	{
		public T Entity { get; private set; }

		public Response(bool success = true, string descriptionMessage = "", Exception internalException = null) : base(success, descriptionMessage, internalException)
		{
		}

		public Response(bool success, string descriptionMessage, T entity, Exception internalException = null) : base(success, descriptionMessage, internalException)
		{
			Entity = entity;
		}
	}
}

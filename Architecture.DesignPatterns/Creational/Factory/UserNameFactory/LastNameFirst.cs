using System;

namespace Architecture.DesignPatterns.Creational.Factory.UserNameFactory
{
	internal class LastNameFirst : UserName
	{
		public LastNameFirst(string username)
		{
			var index = username.Trim().IndexOf(",", StringComparison.Ordinal);

			if (index <= 0) return;

			LastName = username.Substring(0, index).Trim();
			FirstName = username.Substring(index + 1).Trim();
		}
	}
}
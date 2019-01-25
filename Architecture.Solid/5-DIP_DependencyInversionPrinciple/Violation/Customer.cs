using System;

namespace Architecture.Solid.DIP.Violation
{
	public class Custumer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime DateInit { get; set; }

		public bool IsValid()
		{
			return EmailServices.IsValid(Email);
		}
	}
}

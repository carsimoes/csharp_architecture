using System;

namespace Architecture.Solid.SRP.Solution
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string IdType { get; set; }
		public DateTime DateInit { get; set; }

		public bool IsValid()
		{
			return EmailServices.IsValid(Email) && IdTypeValidation.IsValid(IdType);
		}
	}
}

using System;

namespace Architecture.Solid.DIP.Solution
{
	public class Customer
	{
		private readonly IEmailServices _emailServices;

		public Customer(IEmailServices emailServices)
		{
			_emailServices = emailServices;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime DateInit { get; set; }

		public bool IsValid()
		{
			return _emailServices.IsValid(Email);
		}
	}
}

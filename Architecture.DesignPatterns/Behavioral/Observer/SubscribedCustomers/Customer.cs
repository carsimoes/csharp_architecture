using System;

namespace Architecture.DesignPatterns.Behavioral.Observer.SubscribedCustomers
{
	public class Customer : ICustomer
	{
		string name;
		public Customer(string name)
		{
			this.name = name;
		}

		public void Update(Product product)
		{
			Console.WriteLine("{0}: {1} Laptop is now available at {2}; Discount = {3}%", name, product.Name, product.CurrentPrice, product.discount);
		}
	}
}
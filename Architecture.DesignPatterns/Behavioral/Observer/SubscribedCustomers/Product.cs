using System.Collections.Generic;

namespace Architecture.DesignPatterns.Behavioral.Observer.SubscribedCustomers
{
	public class Product : IProduct
	{
		string name;
		float basePrice;
		float currentPrice;

		List<Customer> customers = new List<Customer>();

		public Product(string name, float basePrice)
		{
			this.name = name;
			this.basePrice = basePrice;
			this.currentPrice = basePrice;
		}

		public float price
		{
			get
			{
				return currentPrice;
			}
			set
			{
				// if price of the laptop will be less than the base price then 
				// notification will forwarded to the subscribers
				currentPrice = value;
				if (value <= basePrice)
					Notify();
			}
		}
		public void Subscribe(Customer customer)
		{
			customers.Add(customer);
		}

		public void Unsubscribe(Customer customer)
		{
			customers.Remove(customer);
		}

		public void Notify()
		{
			foreach (Customer observer in customers)
			{
				observer.Update(this);
			}
		}

		public string Name
		{
			get { return name; }
		}

		public float discount
		{
			get { return (basePrice - currentPrice) * 100 / basePrice; }
		}
		public float CurrentPrice
		{
			get { return currentPrice; }
		}
	}
}
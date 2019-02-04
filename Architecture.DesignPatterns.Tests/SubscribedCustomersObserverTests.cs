using Architecture.DesignPatterns.Behavioral.Observer.SubscribedCustomers;
using System;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class SubscribedCustomersObserverTests
	{
		[Fact]
		public void SimpleTest()
		{
			bool pass = true;
			try
			{
				Product Laptop = new Product("DELL", 1000);
				Console.WriteLine("--------Customer 1 and Customer 2 is subscribed to the Laptop Product----------");

				// attach or subscribe customer 1
				Customer Customer1 = new Customer("customer 1");
				Laptop.Subscribe(Customer1);

				// attach or subscribe customer 2
				Customer Customer2 = new Customer("customer 2");
				Laptop.Subscribe(Customer2);

				// publish notification to the subscribers
				Laptop.price = 800;

				Console.WriteLine("--------customer 2 is unsubscribed and customer 3 is subscribed to the Laptop Product----------");
				// customer 2 is unsubscribed and customer 3 is subscribed
				Laptop.Unsubscribe(Customer2);

				Customer Customer3 = new Customer("customer 3");
				Laptop.Subscribe(Customer3);
				Laptop.price = 900;

				Console.ReadLine();
			}
			catch
			{
				pass = false;
			}

			Assert.True(pass);
		}
	}
}

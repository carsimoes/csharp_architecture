using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Behavioral.Observer.SubscribedCustomers
{
	public interface IProduct
	{
		// attach observer
		void Subscribe(Customer customer);

		// detach observer
		void Unsubscribe(Customer customer);

		// publish notification to the subscribers
		void Notify();
	}
}

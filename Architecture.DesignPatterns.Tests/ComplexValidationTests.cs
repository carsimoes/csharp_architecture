using Architecture.DesignPatterns.Behavioral.ChainOfResponsibility.ComplexValidation;
using System;
using System.Linq;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{

	//Validation based on Chain of the Responsibility pattern is very handy and gives a lot of benefits:

	//Improves readability(as you see controller is flat – no spaghetti code)
	//Handling complex validation by several objects in chain structure, which encapsulates the logic
	//Flexibility in assigning responsibilities to objects
	//Easy development and maintenance.So when business requirements change, just modify concrete validator or create a new one and hook it to the chain
	//Objects are independent, they dont’t know nothing about the chain structur

	public class ComplexValidationTests
	{

		//Business validation rules

		//DateFrom is not null
		//DateFrom is greater than now
		//DateTo is not null
		//DateTo is greater than DateFrom
		//One bedroom Exclusive is not avaliable

		[Fact]
		public void DateFromIsNotGreaterThanNow()
		{
			ApartmentBooking model = new ApartmentBooking()
			{
				DateFrom = DateTime.Now.AddDays(-1)
			};

			var errorsResult = ApartmentBookingValidationContext.Validate(model);

			if (errorsResult.Any())
			{
				foreach (var error in errorsResult)
				{
					//error.Key, error.Value
				}
			}
			else
			{
				//ok
			}

			Assert.True(errorsResult.First().Key == "DateFrom");

		}
	}
}

using System;
using System.Collections.Generic;

namespace Architecture.DesignPatterns.Behavioral.ChainOfResponsibility.ComplexValidation
{
	public class DateFromRequiredValidator : ValidatorBase
	{
		public override Dictionary<string, string> HandleValidation(ApartmentBooking model)
		{
			if (model.DateFrom == DateTime.MinValue)
			{
				ErrorsResult.Add("DateFrom", "Date from field is required");
				return ErrorsResult;
			}

			if (Successor != null)
				return Successor.HandleValidation(model);

			return ErrorsResult;
		}
	}
}
using System;
using System.Collections.Generic;

namespace Architecture.DesignPatterns.Behavioral.ChainOfResponsibility.ComplexValidation
{
	public class DateToRangeValidator : ValidatorBase
	{
		public override Dictionary<string, string> HandleValidation(ApartmentBooking model)
		{
			if (model.DateTo <= model.DateFrom)
			{
				ErrorsResult.Add("DateTo", "Date to should be grater than Date from");
				return ErrorsResult;
			}

			if (Successor != null)
				return Successor.HandleValidation(model);

			return ErrorsResult;
		}
	}
}
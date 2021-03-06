﻿using System;
using System.Collections.Generic;

namespace Architecture.DesignPatterns.Behavioral.ChainOfResponsibility.ComplexValidation
{
	public class DateFromRangeValidator : ValidatorBase
	{
		public override Dictionary<string, string> HandleValidation(ApartmentBooking model)
		{
			if (model.DateFrom < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
			{
				ErrorsResult.Add("DateFrom", "Date from should be grater than now");
				return ErrorsResult;
			}

			if (Successor != null)
				return Successor.HandleValidation(model);

			return ErrorsResult;
		}
	}
}
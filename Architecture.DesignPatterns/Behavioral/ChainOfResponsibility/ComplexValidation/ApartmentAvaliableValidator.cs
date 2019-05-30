using System.Collections.Generic;

namespace Architecture.DesignPatterns.Behavioral.ChainOfResponsibility.ComplexValidation
{
	public class ApartmentAvaliableValidator : ValidatorBase
	{
		public override Dictionary<string, string> HandleValidation(ApartmentBooking model)
		{
			/* Dummy validation */
			if (model.ApartmentType == ApartmentType.OneBedroomExecutive)
			{
				ErrorsResult.Add("ApartmentType", string.Format("{0} is currently not avaliable", model.ApartmentType));
				return ErrorsResult;
			}

			if (Successor != null)
				return Successor.HandleValidation(model);

			return ErrorsResult;
		}
	}
}
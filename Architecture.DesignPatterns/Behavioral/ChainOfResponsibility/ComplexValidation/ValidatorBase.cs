using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DesignPatterns.Behavioral.ChainOfResponsibility.ComplexValidation
{
	public abstract class ValidatorBase
	{
		protected ValidatorBase Successor { get; private set; }
		protected Dictionary<string, string> ErrorsResult { get; set; }

		protected ValidatorBase()
		{
			ErrorsResult = new Dictionary<string, string>();
		}

		public abstract Dictionary<string, string> HandleValidation(ApartmentBooking model);

		/// <summary>
		/// Set next validation
		/// </summary>
		/// <param name="successor"></param>
		public void SetSuccessor(ValidatorBase successor)
		{
			this.Successor = successor;
		}
	}
}

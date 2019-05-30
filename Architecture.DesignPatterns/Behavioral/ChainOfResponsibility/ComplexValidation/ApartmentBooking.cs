using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Architecture.DesignPatterns.Behavioral.ChainOfResponsibility.ComplexValidation
{
	public class ApartmentBooking
	{
		public int Id { get; set; }
		public ApartmentType ApartmentType { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }
	}

	public enum ApartmentType : byte
	{
		[Display(Name = "One Bedroom")]
		OneBedroom,
		[Display(Name = "One Bedroom Executive")]
		OneBedroomExecutive,
		[Display(Name = "Two Bedroom")]
		TwoBedroom,
	}
}

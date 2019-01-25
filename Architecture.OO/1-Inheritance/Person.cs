using System;

namespace architecture.OO
{
	public class Person
	{
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }

		public int Age()
		{
			var now = DateTime.Now;
			var age = now.Year - BirthDate.Year;

			if (now < BirthDate.AddYears(age)) age--;

			return age;
		}
	}
}

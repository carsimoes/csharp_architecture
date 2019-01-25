using System;

namespace architecture.OO
{
	public class Employee : Person
	{
		public DateTime BeginDate { get; set; }

		public string Id { get; set; }

		public class Run
		{
			public void Exec()
			{
				var employee = new Employee()
				{
					Name = "Sr No Regrets",
					BirthDate = Convert.ToDateTime("1990/01/01"),
					BeginDate = DateTime.Now,
					Id = "0123456",
				};
			}
		}
	}
}

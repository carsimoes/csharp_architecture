using System;

namespace Architecture.Solid.SRP.Violation
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string IdType { get; set; }
		public DateTime DateInit { get; set; }

		public string AddCustomer()
		{
			if (!Email.Contains("@"))
				return "E-mail is invalid.";

			if (IdType.Length != 11)
				return "IdType is invalid.";


			//using (var cn = new SqlConnection())
			//{
			//	var cmd = new SqlCommand();

			//	//Insert...

			//	cn.Open();
			//	cmd.ExecuteNonQuery();
			//}

			//var mail = new MailMessage("bla@bla.com", Email);
			//var client = new SmtpClient
			//{
			////....
			//};

			//mail.Subject = "Welcome.";
			//mail.Body = "Congrats.";
			//client.Send(mail);

			return "Customer registered!";
		}
	}
}

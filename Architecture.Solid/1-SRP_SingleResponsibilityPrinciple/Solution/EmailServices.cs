using System.Net.Mail;

namespace Architecture.Solid.SRP.Solution
{
	public static class EmailServices
	{
		public static bool IsValid(string email)
		{
			return email.Contains("@");
		}

		public static void Send(string from, string to, string topic, string message)
		{
			var mail = new MailMessage(from, to);
			var client = new SmtpClient
			{
				Port = 25,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Host = "smtp.google.com"
			};

			mail.Subject = topic;
			mail.Body = message;
			client.Send(mail);
		}
	}
}

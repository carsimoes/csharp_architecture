namespace Architecture.Solid.DIP.Violation
{
	public static class EmailServices
	{
		public static bool IsValid(string email)
		{
			return email.Contains("@");
		}

		public static void Send(string from, string to, string topic, string message)
		{
			//..
		}
	}
}

namespace Architecture.Solid.DIP.Solution
{
	public interface IEmailServices
	{
		bool IsValid(string email);
		void Send(string from, string to, string topic, string message);
	}
}

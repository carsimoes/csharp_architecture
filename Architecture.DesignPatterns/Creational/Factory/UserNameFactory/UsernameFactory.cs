namespace Architecture.DesignPatterns.Creational.Factory.UserNameFactory
{
	public class UsernameFactory
	{
		public UserName GetUserName(string name)
		{
			if (name.Contains(",")) return new LastNameFirst(name);

			return new FirstNameFirst(name);
		}
	}
}

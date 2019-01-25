namespace Architecture.Solid.OCP.Violation
{
	public class DebtAccount
	{
		public void GetMoney(decimal value, string account, AccountType accountType)
		{
			if (accountType == AccountType.Type1)
			{
				//..
			}

			if (accountType == AccountType.Type2)
			{
				//..
			}
		}
	}
}

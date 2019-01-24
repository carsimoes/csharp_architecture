namespace Architecture.Solid.OCP.Solution
{
	public class DebtType2 : DebtAccount
	{
		public override string Debt(decimal value, string account)
		{
			//...
			return FormatTransaction();
		}
	}
}

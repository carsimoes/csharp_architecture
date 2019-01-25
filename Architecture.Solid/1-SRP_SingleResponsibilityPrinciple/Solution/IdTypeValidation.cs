namespace Architecture.Solid.SRP.Solution
{
	public static class IdTypeValidation
	{
		public static bool IsValid(string idType)
		{
			return idType.Length == 11;
		}
	}
}

namespace Architecture.OO
{
	public class HandleCombustionEngine
	{
		public void Init()
		{
			var combustionEngine = new CombustionEngine();
			combustionEngine.On();
			combustionEngine.BeginEngine();
			combustionEngine.Off();
		}
	}
}

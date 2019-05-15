namespace Architecture.DesignPatterns.Behavioral.Command.LightCommand
{
	public class LightOnCommand : Command
	{
		Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}

		public void Execute()
		{
			light.On();
		}
	}
}

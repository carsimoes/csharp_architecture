namespace Architecture.DesignPatterns.Behavioral.Command.LightCommand
{
	public class LightOffCommand : Command
	{
		Light light;

		public LightOffCommand(Light light)
		{
			this.light = light;
		}

		public void Execute()
		{
			light.Off();
		}
	}
}

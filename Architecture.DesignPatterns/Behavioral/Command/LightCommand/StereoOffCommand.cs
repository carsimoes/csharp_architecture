namespace Architecture.DesignPatterns.Behavioral.Command.LightCommand
{
	public class StereoOffCommand : Command
	{
		Stereo stereo;

		public StereoOffCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public void Execute()
		{
			stereo.Off();
		}
	}
}

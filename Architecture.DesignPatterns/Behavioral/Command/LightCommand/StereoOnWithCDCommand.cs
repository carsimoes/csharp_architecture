namespace Architecture.DesignPatterns.Behavioral.Command.LightCommand
{
	public class StereoOnWithCDCommand : Command
	{
		Stereo stereo;

		public StereoOnWithCDCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public void Execute()
		{
			stereo.On();
			stereo.SetCD();
			stereo.SetVolume(11);
		}
	}
}

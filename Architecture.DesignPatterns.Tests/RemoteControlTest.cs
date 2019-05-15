using Architecture.DesignPatterns.Behavioral.Command.LightCommand;
using Xunit;

namespace Architecture.DesignPatterns.Tests
{
	public class RemoteControlTest
	{
		[Fact]
		public void Test()
		{
			SimpleRemoteControl remote = new SimpleRemoteControl();
			Light light = new Light();
			Stereo stereo = new Stereo();

			// we can change command dynamically 
			remote.SetCommand(new LightOnCommand(light));
			remote.ButtonWasPressed();
			remote.SetCommand(new StereoOnWithCDCommand(stereo));
			remote.ButtonWasPressed();
			remote.SetCommand(new StereoOffCommand(stereo));
			remote.ButtonWasPressed();

			Assert.True(true);
		}
	}
}

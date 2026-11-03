namespace UnityEngine.InputSystem.DualShock;

[Token(Token = "0x2000166")]
public interface IDualShockHaptics : IDualMotorRumble, IHaptics
{

	[Token(Token = "0x6000F88")]
	public void SetLightBarColor(Color color) { }

}


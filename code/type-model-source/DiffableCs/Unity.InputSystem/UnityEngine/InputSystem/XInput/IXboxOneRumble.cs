namespace UnityEngine.InputSystem.XInput;

[Token(Token = "0x20000FF")]
public interface IXboxOneRumble : IDualMotorRumble, IHaptics
{

	[Token(Token = "0x6000CC3")]
	public void SetMotorSpeeds(float lowFrequency, float highFrequency, float leftTrigger, float rightTrigger) { }

}


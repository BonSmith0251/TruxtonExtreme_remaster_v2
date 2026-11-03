namespace UnityEngine.InputSystem.Haptics;

[Token(Token = "0x2000175")]
public interface IDualMotorRumble : IHaptics
{

	[Token(Token = "0x6000FAA")]
	public void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

}


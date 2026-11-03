namespace UnityEngine.InputSystem.Haptics;

[Token(Token = "0x2000176")]
public interface IHaptics
{

	[Token(Token = "0x6000FAB")]
	public void PauseHaptics() { }

	[Token(Token = "0x6000FAD")]
	public void ResetHaptics() { }

	[Token(Token = "0x6000FAC")]
	public void ResumeHaptics() { }

}


namespace UnityEngine.InputSystem;

[Token(Token = "0x200003D")]
public enum InputActionPhase : int
{
	Disabled = 0,
	Waiting = 1,
	Started = 2,
	Performed = 3,
	Canceled = 4,
}


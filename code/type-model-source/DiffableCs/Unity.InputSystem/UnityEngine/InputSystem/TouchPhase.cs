namespace UnityEngine.InputSystem;

[Token(Token = "0x20000BD")]
public enum TouchPhase : int
{
	None = 0,
	Began = 1,
	Moved = 2,
	Ended = 3,
	Canceled = 4,
	Stationary = 5,
}


namespace UnityEngine;

[Flags]
[Token(Token = "0x2000005")]
public enum EventModifiers : int
{
	None = 0,
	Shift = 1,
	Control = 2,
	Alt = 4,
	Command = 8,
	Numeric = 16,
	CapsLock = 32,
	FunctionKey = 64,
}


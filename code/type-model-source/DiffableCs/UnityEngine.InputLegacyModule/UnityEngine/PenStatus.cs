namespace UnityEngine;

[Flags]
[Token(Token = "0x2000006")]
public enum PenStatus : int
{
	None = 0,
	Contact = 1,
	Barrel = 2,
	Inverted = 4,
	Eraser = 8,
}


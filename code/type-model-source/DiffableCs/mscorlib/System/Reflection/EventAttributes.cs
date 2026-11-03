namespace System.Reflection;

[Flags]
[Token(Token = "0x20004DE")]
public enum EventAttributes : int
{
	None = 0,
	SpecialName = 512,
	RTSpecialName = 1024,
	ReservedMask = 1024,
}


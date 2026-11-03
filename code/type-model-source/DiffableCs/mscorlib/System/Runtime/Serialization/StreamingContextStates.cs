namespace System.Runtime.Serialization;

[ComVisible(True)]
[Flags]
[Token(Token = "0x20003FC")]
public enum StreamingContextStates : int
{
	CrossProcess = 1,
	CrossMachine = 2,
	File = 4,
	Persistence = 8,
	Remoting = 16,
	Other = 32,
	Clone = 64,
	CrossAppDomain = 128,
	All = 255,
}


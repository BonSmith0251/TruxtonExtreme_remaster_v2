namespace UnityEngine.Audio;

[Token(Token = "0x2000021")]
internal enum ProcessorFunction : uint
{
	Process = 1,
	Update = 2,
	OutputProcessEarly = 3,
	OutputProcess = 4,
	OutputProcessEnd = 5,
	OutputRemoved = 6,
}


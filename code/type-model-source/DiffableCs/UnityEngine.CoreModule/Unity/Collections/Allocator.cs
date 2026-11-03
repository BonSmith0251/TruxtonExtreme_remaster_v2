namespace Unity.Collections;

[Token(Token = "0x2000055")]
[UsedByNativeCode]
public enum Allocator : int
{
	Invalid = 0,
	None = 1,
	Temp = 2,
	TempJob = 3,
	Persistent = 4,
	AudioKernel = 5,
	Domain = 6,
	FirstUserIndex = 64,
}


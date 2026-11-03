namespace UnityEngine.Video;

[RequiredByNativeCode]
[Token(Token = "0x2000008")]
public enum VideoTimeReference : int
{
	Freerun = 0,
	InternalTime = 1,
	ExternalTime = 2,
}


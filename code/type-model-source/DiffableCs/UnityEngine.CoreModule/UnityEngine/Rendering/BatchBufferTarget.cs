namespace UnityEngine.Rendering;

[Token(Token = "0x200039F")]
public enum BatchBufferTarget : int
{
	Unknown = 0,
	UnsupportedByUnderlyingGraphicsApi = -1,
	RawBuffer = 1,
	ConstantBuffer = 2,
}


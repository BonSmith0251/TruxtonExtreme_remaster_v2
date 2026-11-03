namespace UnityEngine;

[Flags]
[Token(Token = "0x200011E")]
public enum RenderTextureMemoryless : int
{
	None = 0,
	Color = 1,
	Depth = 2,
	MSAA = 4,
}


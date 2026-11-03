namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x200002A")]
public enum ClearFlag : int
{
	None = 0,
	Color = 1,
	Depth = 2,
	Stencil = 4,
	DepthStencil = 6,
	ColorStencil = 5,
	All = 7,
}


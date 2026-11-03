namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x200035C")]
public enum RenderTargetFlags : int
{
	None = 0,
	ReadOnlyDepth = 1,
	ReadOnlyStencil = 2,
	ReadOnlyDepthStencil = 3,
}


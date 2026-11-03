namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x20003C4")]
public enum SubPassFlags : int
{
	None = 0,
	ReadOnlyDepth = 2,
	ReadOnlyStencil = 4,
	ReadOnlyDepthStencil = 6,
	UseShadingRateImage = 8,
	TileProperties = 16,
	MultiviewRenderRegionsCompatible = 32,
}


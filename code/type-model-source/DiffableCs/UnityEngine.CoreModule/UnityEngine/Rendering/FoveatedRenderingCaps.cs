namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x200036A")]
public enum FoveatedRenderingCaps : int
{
	None = 0,
	FoveationImage = 1,
	NonUniformRaster = 2,
	ModeChangeOnlyBeforeRenderTargetSet = 4,
}


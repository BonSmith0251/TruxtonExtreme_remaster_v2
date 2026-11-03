namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x20003EC")]
public enum RenderStateMask : int
{
	Nothing = 0,
	Blend = 1,
	Raster = 2,
	Depth = 4,
	Stencil = 8,
	Everything = 15,
}


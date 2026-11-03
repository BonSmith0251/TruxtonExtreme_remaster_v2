namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000282")]
internal enum RenderGraphPassType : int
{
	Legacy = 0,
	Unsafe = 1,
	Raster = 2,
	Compute = 3,
}


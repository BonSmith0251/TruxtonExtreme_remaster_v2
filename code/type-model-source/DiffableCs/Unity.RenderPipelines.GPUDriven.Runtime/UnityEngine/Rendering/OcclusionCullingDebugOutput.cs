namespace UnityEngine.Rendering;

[Token(Token = "0x200002C")]
internal struct OcclusionCullingDebugOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008C")]
	public RTHandle occluderDepthPyramid; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400008D")]
	public GraphicsBuffer occlusionDebugOverlay; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008E")]
	public OcclusionCullingDebugShaderVariables cb; //Field offset: 0x10

}


namespace UnityEngine.Rendering;

[Token(Token = "0x20003D4")]
internal struct CullingAllocationInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C70")]
	public VisibleLight* visibleLightsPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C71")]
	public VisibleLight* visibleOffscreenVertexLightsPtr; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C72")]
	public VisibleReflectionProbe* visibleReflectionProbesPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C73")]
	public int visibleLightCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C74")]
	public int visibleOffscreenVertexLightCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C75")]
	public int visibleReflectionProbeCount; //Field offset: 0x20

}


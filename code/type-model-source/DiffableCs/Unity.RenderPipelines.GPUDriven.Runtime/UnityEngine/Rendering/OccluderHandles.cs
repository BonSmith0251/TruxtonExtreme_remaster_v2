namespace UnityEngine.Rendering;

[Token(Token = "0x20000A6")]
internal struct OccluderHandles
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000316")]
	public TextureHandle occluderDepthPyramid; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000317")]
	public BufferHandle occlusionDebugOverlay; //Field offset: 0x10

	[Address(RVA = "0x2CF9750", Offset = "0x2CF8B50", Length = "0x49")]
	[Token(Token = "0x60002FA")]
	public bool IsValid() { }

	[Address(RVA = "0x2CF97A0", Offset = "0x2CF8BA0", Length = "0xB7")]
	[Token(Token = "0x60002FC")]
	public void UseForOccluderUpdate(IBaseRenderGraphBuilder builder) { }

	[Address(RVA = "0x2CF9860", Offset = "0x2CF8C60", Length = "0xB7")]
	[Token(Token = "0x60002FB")]
	public void UseForOcclusionTest(IBaseRenderGraphBuilder builder) { }

}


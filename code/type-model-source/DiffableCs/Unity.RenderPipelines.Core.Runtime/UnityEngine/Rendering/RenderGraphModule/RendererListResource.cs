namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000297")]
internal struct RendererListResource
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B8E")]
	public RendererListParams desc; //Field offset: 0x0
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000B8F")]
	public RendererList rendererList; //Field offset: 0x130

	[Address(RVA = "0x2CAA550", Offset = "0x2CA9950", Length = "0x115")]
	[Token(Token = "0x60012B7")]
	internal RendererListResource(in RendererListParams desc) { }

}


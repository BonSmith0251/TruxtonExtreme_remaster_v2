namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000298")]
internal struct RendererListLegacyResource
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B90")]
	public RendererList rendererList; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B91")]
	public bool isActive; //Field offset: 0x18

	[Address(RVA = "0x2CAA530", Offset = "0x2CA9930", Length = "0x15")]
	[Token(Token = "0x60012B8")]
	internal RendererListLegacyResource(in bool active = false) { }

}


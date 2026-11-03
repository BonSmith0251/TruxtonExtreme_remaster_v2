namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("TextureResource ({desc.name})")]
[Token(Token = "0x20002A4")]
internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
{
	[Token(Token = "0x4000BDE")]
	private static int m_TextureCreationIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000BDF")]
	internal TextureUVOriginSelection textureUVOrigin; //Field offset: 0xC0

	[Address(RVA = "0x2CAC1B0", Offset = "0x2CAB5B0", Length = "0x39")]
	[Token(Token = "0x60012FC")]
	public TextureResource() { }

	[Address(RVA = "0x2CABBA0", Offset = "0x2CAAFA0", Length = "0x3C0")]
	[Token(Token = "0x60012F7")]
	public virtual void CreateGraphicsResource() { }

	[Address(RVA = "0x2CABF60", Offset = "0x2CAB360", Length = "0xB")]
	[Token(Token = "0x60012F6")]
	public virtual int GetDescHashCode() { }

	[Address(RVA = "0x2CABF70", Offset = "0x2CAB370", Length = "0x63")]
	[Token(Token = "0x60012F5")]
	public virtual string GetName() { }

	[Address(RVA = "0x2CABFE0", Offset = "0x2CAB3E0", Length = "0xAC")]
	[Token(Token = "0x60012FA")]
	public virtual void LogCreation(RenderGraphLogger logger) { }

	[Address(RVA = "0x2CAC090", Offset = "0x2CAB490", Length = "0x7F")]
	[Token(Token = "0x60012FB")]
	public virtual void LogRelease(RenderGraphLogger logger) { }

	[Address(RVA = "0x2CAC110", Offset = "0x2CAB510", Length = "0x4C")]
	[Token(Token = "0x60012F9")]
	public virtual void ReleaseGraphicsResource() { }

	[Address(RVA = "0x2CAC160", Offset = "0x2CAB560", Length = "0x50")]
	[Token(Token = "0x60012F8")]
	public virtual void UpdateGraphicsResource() { }

}


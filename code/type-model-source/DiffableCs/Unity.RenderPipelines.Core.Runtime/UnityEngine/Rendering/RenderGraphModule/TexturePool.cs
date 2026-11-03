namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x20002A5")]
internal class TexturePool : RenderGraphResourcePool<RTHandle>
{

	[Address(RVA = "0x2CABB40", Offset = "0x2CAAF40", Length = "0x5A")]
	[Token(Token = "0x6001302")]
	public TexturePool() { }

	[Address(RVA = "0x2CABA70", Offset = "0x2CAAE70", Length = "0x25")]
	[Token(Token = "0x60012FE")]
	protected virtual string GetResourceName(in RTHandle res) { }

	[Address(RVA = "0x2CABAA0", Offset = "0x2CAAEA0", Length = "0x20")]
	[Token(Token = "0x60012FF")]
	protected virtual long GetResourceSize(in RTHandle res) { }

	[Address(RVA = "0x2CABAD0", Offset = "0x2CAAED0", Length = "0x2C")]
	[Token(Token = "0x6001300")]
	protected virtual string GetResourceTypeName() { }

	[Address(RVA = "0x2CABB00", Offset = "0x2CAAF00", Length = "0x1F")]
	[Token(Token = "0x6001301")]
	protected virtual int GetSortIndex(RTHandle res) { }

	[Address(RVA = "0x2CABB20", Offset = "0x2CAAF20", Length = "0x1F")]
	[Token(Token = "0x60012FD")]
	protected virtual void ReleaseInternalResource(RTHandle res) { }

}


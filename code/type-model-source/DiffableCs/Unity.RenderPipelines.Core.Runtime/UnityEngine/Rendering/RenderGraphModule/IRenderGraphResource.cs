namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200029B")]
internal class IRenderGraphResource
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B9E")]
	public bool imported; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000B9F")]
	public bool shared; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000BA0")]
	public bool sharedExplicitRelease; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4000BA1")]
	public bool requestFallBack; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000BA2")]
	public uint writeCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BA3")]
	public uint readCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000BA4")]
	public int cachedHash; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BA5")]
	public int transientPassIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000BA6")]
	public int sharedResourceLastFrameUsed; //Field offset: 0x24

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60012D4")]
	public IRenderGraphResource() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012CC")]
	public override void CreateGraphicsResource() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012CB")]
	public override void CreatePooledGraphicsResource(bool forceResourceCreation) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60012D3")]
	public override int GetDescHashCode() { }

	[Address(RVA = "0x2C8F3E0", Offset = "0x2C8E7E0", Length = "0x2C")]
	[Token(Token = "0x60012C6")]
	public override string GetName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60012D2")]
	public override int GetSortIndex() { }

	[Address(RVA = "0x1DF4B40", Offset = "0x1DF3F40", Length = "0x4")]
	[Token(Token = "0x60012C9")]
	public override void IncrementReadCount() { }

	[Address(RVA = "0x2C8F410", Offset = "0x2C8E810", Length = "0x9")]
	[Token(Token = "0x60012C8")]
	public override uint IncrementWriteCount() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60012C7")]
	public override bool IsCreated() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012D0")]
	public override void LogCreation(RenderGraphLogger logger) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012D1")]
	public override void LogRelease(RenderGraphLogger logger) { }

	[Address(RVA = "0x2C8F420", Offset = "0x2C8E820", Length = "0x11")]
	[Token(Token = "0x60012CA")]
	public override bool NeedsFallBack() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012CF")]
	public override void ReleaseGraphicsResource() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012CE")]
	public override void ReleasePooledGraphicsResource(int frameIndex) { }

	[Address(RVA = "0x2C8F440", Offset = "0x2C8E840", Length = "0x1D")]
	[Token(Token = "0x60012C5")]
	public override void Reset(IRenderGraphResourcePool _ = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012CD")]
	public override void UpdateGraphicsResource() { }

}


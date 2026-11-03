namespace UnityEngine.Rendering;

[Token(Token = "0x2000039")]
internal struct RangeKey : IEquatable<RangeKey>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BD")]
	public byte layer; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000BE")]
	public uint renderingLayerMask; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BF")]
	public MotionVectorGenerationMode motionMode; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000C0")]
	public ShadowCastingMode shadowCastingMode; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C1")]
	public bool staticShadowCaster; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000C2")]
	public int rendererPriority; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C3")]
	public bool supportsIndirect; //Field offset: 0x18

	[Address(RVA = "0x2CD41A0", Offset = "0x2CD35A0", Length = "0x7F")]
	[Token(Token = "0x6000129")]
	public override bool Equals(RangeKey other) { }

	[Address(RVA = "0x2CD4220", Offset = "0x2CD3620", Length = "0x63")]
	[Token(Token = "0x600012A")]
	public virtual int GetHashCode() { }

}


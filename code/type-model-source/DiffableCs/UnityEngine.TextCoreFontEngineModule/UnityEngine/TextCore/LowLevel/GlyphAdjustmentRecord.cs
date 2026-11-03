namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000012")]
[UsedByNativeCode]
public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("glyphIndex")]
	[SerializeField]
	[Token(Token = "0x4000088")]
	private uint m_GlyphIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("glyphValueRecord")]
	[SerializeField]
	[Token(Token = "0x4000089")]
	private GlyphValueRecord m_GlyphValueRecord; //Field offset: 0x4

	[Token(Token = "0x17000028")]
	public uint glyphIndex
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000029")]
	public GlyphValueRecord glyphValueRecord
	{
		[Address(RVA = "0x30D0960", Offset = "0x30CFD60", Length = "0xB")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 11
	}

	[Address(RVA = "0xAEE2E0", Offset = "0xAED6E0", Length = "0xB")]
	[Token(Token = "0x6000094")]
	public GlyphAdjustmentRecord(uint glyphIndex, GlyphValueRecord glyphValueRecord) { }

	[Address(RVA = "0x3171120", Offset = "0x3170520", Length = "0x65")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000096")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3171090", Offset = "0x3170490", Length = "0x88")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000097")]
	public override bool Equals(GlyphAdjustmentRecord other) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6000092")]
	public uint get_glyphIndex() { }

	[Address(RVA = "0x30D0960", Offset = "0x30CFD60", Length = "0xB")]
	[Token(Token = "0x6000093")]
	public GlyphValueRecord get_glyphValueRecord() { }

	[Address(RVA = "0x3171190", Offset = "0x3170590", Length = "0x55")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000095")]
	public virtual int GetHashCode() { }

}


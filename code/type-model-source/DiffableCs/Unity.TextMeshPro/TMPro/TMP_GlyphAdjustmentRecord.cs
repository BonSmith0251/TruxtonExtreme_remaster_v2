namespace TMPro;

[Token(Token = "0x200005C")]
public struct TMP_GlyphAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400026E")]
	internal uint m_GlyphIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400026F")]
	internal TMP_GlyphValueRecord m_GlyphValueRecord; //Field offset: 0x4

	[Token(Token = "0x17000087")]
	public uint glyphIndex
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60002D8")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60002D9")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000088")]
	public TMP_GlyphValueRecord glyphValueRecord
	{
		[Address(RVA = "0xAEF340", Offset = "0xAEE740", Length = "0xB")]
		[Token(Token = "0x60002DA")]
		 get { } //Length: 11
		[Address(RVA = "0x17CB510", Offset = "0x17CA910", Length = "0x8")]
		[Token(Token = "0x60002DB")]
		 set { } //Length: 8
	}

	[Address(RVA = "0xAEE2E0", Offset = "0xAED6E0", Length = "0xB")]
	[Token(Token = "0x60002DC")]
	public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	[Address(RVA = "0x2EC85E0", Offset = "0x2EC79E0", Length = "0xC1")]
	[Token(Token = "0x60002DD")]
	internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60002D8")]
	public uint get_glyphIndex() { }

	[Address(RVA = "0xAEF340", Offset = "0xAEE740", Length = "0xB")]
	[Token(Token = "0x60002DA")]
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60002D9")]
	public void set_glyphIndex(uint value) { }

	[Address(RVA = "0x17CB510", Offset = "0x17CA910", Length = "0x8")]
	[Token(Token = "0x60002DB")]
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

}


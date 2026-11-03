namespace TMPro;

[Token(Token = "0x2000052")]
public class KerningPair
{
	[Token(Token = "0x4000257")]
	internal static KerningPair empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("AscII_Left")]
	[SerializeField]
	[Token(Token = "0x4000252")]
	private uint m_FirstGlyph; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000253")]
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("AscII_Right")]
	[SerializeField]
	[Token(Token = "0x4000254")]
	private uint m_SecondGlyph; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000255")]
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("XadvanceOffset")]
	[Token(Token = "0x4000256")]
	public float xOffset; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000258")]
	private bool m_IgnoreSpacingAdjustments; //Field offset: 0x3C

	[Token(Token = "0x1700007D")]
	public uint firstGlyph
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600029F")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x60002A0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700007E")]
	public GlyphValueRecord_Legacy firstGlyphAdjustments
	{
		[Address(RVA = "0xFBEB00", Offset = "0xFBDF00", Length = "0xB")]
		[Token(Token = "0x60002A1")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000081")]
	public bool ignoreSpacingAdjustments
	{
		[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
		[Token(Token = "0x60002A5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700007F")]
	public uint secondGlyph
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60002A2")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x60002A3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000080")]
	public GlyphValueRecord_Legacy secondGlyphAdjustments
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x60002A4")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2EC5770", Offset = "0x2EC4B70", Length = "0x84")]
	[Token(Token = "0x60002AA")]
	private static KerningPair() { }

	[Address(RVA = "0x2EC58B0", Offset = "0x2EC4CB0", Length = "0x29")]
	[Token(Token = "0x60002A6")]
	public KerningPair() { }

	[Address(RVA = "0x2EC5800", Offset = "0x2EC4C00", Length = "0x46")]
	[Token(Token = "0x60002A7")]
	public KerningPair(uint left, uint right, float offset) { }

	[Address(RVA = "0x2EC5850", Offset = "0x2EC4C50", Length = "0x54")]
	[Token(Token = "0x60002A8")]
	public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	[Address(RVA = "0x2EC5760", Offset = "0x2EC4B60", Length = "0x7")]
	[Token(Token = "0x60002A9")]
	internal void ConvertLegacyKerningData() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600029F")]
	public uint get_firstGlyph() { }

	[Address(RVA = "0xFBEB00", Offset = "0xFBDF00", Length = "0xB")]
	[Token(Token = "0x60002A1")]
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
	[Token(Token = "0x60002A5")]
	public bool get_ignoreSpacingAdjustments() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60002A2")]
	public uint get_secondGlyph() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x60002A4")]
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x60002A0")]
	public void set_firstGlyph(uint value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x60002A3")]
	public void set_secondGlyph(uint value) { }

}


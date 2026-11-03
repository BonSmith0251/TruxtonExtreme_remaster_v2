namespace TMPro;

[Token(Token = "0x200000C")]
public struct MarkToMarkAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	private uint m_BaseMarkGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	private uint m_CombiningMarkGlyphID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; //Field offset: 0x10

	[Token(Token = "0x1700000A")]
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		[Address(RVA = "0xAEF320", Offset = "0xAEE720", Length = "0x13")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 19
		[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
		[Token(Token = "0x6000027")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public uint baseMarkGlyphID
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000025")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700000B")]
	public uint combiningMarkGlyphID
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x6000029")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000C")]
	public MarkPositionAdjustment combiningMarkPositionAdjustment
	{
		[Address(RVA = "0x195BD70", Offset = "0x195B170", Length = "0x13")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 19
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x600002B")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xAEF320", Offset = "0xAEE720", Length = "0x13")]
	[Token(Token = "0x6000026")]
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000024")]
	public uint get_baseMarkGlyphID() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x6000028")]
	public uint get_combiningMarkGlyphID() { }

	[Address(RVA = "0x195BD70", Offset = "0x195B170", Length = "0x13")]
	[Token(Token = "0x600002A")]
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
	[Token(Token = "0x6000027")]
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000025")]
	public void set_baseMarkGlyphID(uint value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[Token(Token = "0x6000029")]
	public void set_combiningMarkGlyphID(uint value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x600002B")]
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }

}


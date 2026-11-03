namespace TMPro;

[Token(Token = "0x200000B")]
public struct MarkToBaseAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000017")]
	private uint m_BaseGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	private uint m_MarkGlyphID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	private MarkPositionAdjustment m_MarkPositionAdjustment; //Field offset: 0x10

	[Token(Token = "0x17000006")]
	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		[Address(RVA = "0xAEF320", Offset = "0xAEE720", Length = "0x13")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 19
		[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
		[Token(Token = "0x600001F")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public uint baseGlyphID
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600001D")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000007")]
	public uint markGlyphID
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public MarkPositionAdjustment markPositionAdjustment
	{
		[Address(RVA = "0x195BD70", Offset = "0x195B170", Length = "0x13")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 19
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000023")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xAEF320", Offset = "0xAEE720", Length = "0x13")]
	[Token(Token = "0x600001E")]
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600001C")]
	public uint get_baseGlyphID() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x6000020")]
	public uint get_markGlyphID() { }

	[Address(RVA = "0x195BD70", Offset = "0x195B170", Length = "0x13")]
	[Token(Token = "0x6000022")]
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
	[Token(Token = "0x600001F")]
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600001D")]
	public void set_baseGlyphID(uint value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[Token(Token = "0x6000021")]
	public void set_markGlyphID(uint value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000023")]
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }

}


namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000017")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MarkToMarkAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("baseMarkGlyphID")]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private uint m_BaseMarkGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("baseMarkAnchor")]
	[SerializeField]
	[Token(Token = "0x4000096")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[NativeName("combiningMarkGlyphID")]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private uint m_CombiningMarkGlyphID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("combiningMarkPositionAdjustment")]
	[SerializeField]
	[Token(Token = "0x4000098")]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; //Field offset: 0x10

	[Token(Token = "0x17000036")]
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		[Address(RVA = "0x31132C0", Offset = "0x31126C0", Length = "0x13")]
		[Token(Token = "0x60000B2")]
		 get { } //Length: 19
		[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
		[Token(Token = "0x60000B3")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000035")]
	public uint baseMarkGlyphID
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x60000B0")]
		 get { } //Length: 5
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60000B1")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000037")]
	public uint combiningMarkGlyphID
	{
		[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 6
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x60000B5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000038")]
	public MarkPositionAdjustment combiningMarkPositionAdjustment
	{
		[Address(RVA = "0x3132A80", Offset = "0x3131E80", Length = "0x13")]
		[Token(Token = "0x60000B6")]
		 get { } //Length: 19
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x60000B7")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x31132C0", Offset = "0x31126C0", Length = "0x13")]
	[Token(Token = "0x60000B2")]
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x60000B0")]
	public uint get_baseMarkGlyphID() { }

	[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
	[Token(Token = "0x60000B4")]
	public uint get_combiningMarkGlyphID() { }

	[Address(RVA = "0x3132A80", Offset = "0x3131E80", Length = "0x13")]
	[Token(Token = "0x60000B6")]
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
	[Token(Token = "0x60000B3")]
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60000B1")]
	public void set_baseMarkGlyphID(uint value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[Token(Token = "0x60000B5")]
	public void set_combiningMarkGlyphID(uint value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x60000B7")]
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }

}


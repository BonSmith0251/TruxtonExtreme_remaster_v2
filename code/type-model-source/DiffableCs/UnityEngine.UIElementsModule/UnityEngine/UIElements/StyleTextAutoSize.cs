namespace UnityEngine.UIElements;

[Token(Token = "0x200049B")]
public struct StyleTextAutoSize : IStyleValue<TextAutoSize>, IEquatable<StyleTextAutoSize>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F3A")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000F3B")]
	private TextAutoSize m_Value; //Field offset: 0x4

	[Token(Token = "0x1700092B")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6002271")]
		 get { } //Length: 5
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6002272")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700092A")]
	public override TextAutoSize value
	{
		[Address(RVA = "0x3290D30", Offset = "0x3290130", Length = "0x25")]
		[Token(Token = "0x600226F")]
		 get { } //Length: 37
		[Address(RVA = "0x3290DF0", Offset = "0x32901F0", Length = "0x14")]
		[Token(Token = "0x6002270")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x3290D20", Offset = "0x3290120", Length = "0xF")]
	[Token(Token = "0x6002273")]
	public StyleTextAutoSize(StyleKeyword keyword) { }

	[Address(RVA = "0x3290D00", Offset = "0x3290100", Length = "0x11")]
	[Token(Token = "0x6002274")]
	internal StyleTextAutoSize(TextAutoSize v, StyleKeyword keyword) { }

	[Address(RVA = "0x3290AD0", Offset = "0x328FED0", Length = "0x77")]
	[Token(Token = "0x6002277")]
	public override bool Equals(StyleTextAutoSize other) { }

	[Address(RVA = "0x3290B50", Offset = "0x328FF50", Length = "0xF1")]
	[Token(Token = "0x6002278")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6002271")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x3290D30", Offset = "0x3290130", Length = "0x25")]
	[Token(Token = "0x600226F")]
	public override TextAutoSize get_value() { }

	[Address(RVA = "0x3290C50", Offset = "0x3290050", Length = "0x3B")]
	[Token(Token = "0x6002279")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3290D60", Offset = "0x3290160", Length = "0x5F")]
	[Token(Token = "0x6002275")]
	public static bool op_Equality(StyleTextAutoSize lhs, StyleTextAutoSize rhs) { }

	[Address(RVA = "0x3290DC0", Offset = "0x32901C0", Length = "0x2F")]
	[Token(Token = "0x6002276")]
	public static StyleTextAutoSize op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6002272")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3290DF0", Offset = "0x32901F0", Length = "0x14")]
	[Token(Token = "0x6002270")]
	public override void set_value(TextAutoSize value) { }

	[Address(RVA = "0x3290C90", Offset = "0x3290090", Length = "0x6A")]
	[Token(Token = "0x600227A")]
	public virtual string ToString() { }

}


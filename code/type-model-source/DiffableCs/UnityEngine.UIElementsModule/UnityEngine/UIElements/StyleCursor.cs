namespace UnityEngine.UIElements;

[Token(Token = "0x200041B")]
public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DB5")]
	private Cursor m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000DB6")]
	private StyleKeyword m_Keyword; //Field offset: 0x18

	[Token(Token = "0x170008B9")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6001F2B")]
		 get { } //Length: 6
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6001F2C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008B8")]
	public override Cursor value
	{
		[Address(RVA = "0x3279CA0", Offset = "0x32790A0", Length = "0x42")]
		[Token(Token = "0x6001F29")]
		 get { } //Length: 66
		[Address(RVA = "0x3279DC0", Offset = "0x32791C0", Length = "0x2D")]
		[Token(Token = "0x6001F2A")]
		 set { } //Length: 45
	}

	[Address(RVA = "0x3279C50", Offset = "0x3279050", Length = "0x2A")]
	[Token(Token = "0x6001F2D")]
	public StyleCursor(StyleKeyword keyword) { }

	[Address(RVA = "0x3279C80", Offset = "0x3279080", Length = "0x1B")]
	[Token(Token = "0x6001F2E")]
	internal StyleCursor(Cursor v, StyleKeyword keyword) { }

	[Address(RVA = "0x3279A80", Offset = "0x3278E80", Length = "0x63")]
	[Token(Token = "0x6001F31")]
	public override bool Equals(StyleCursor other) { }

	[Address(RVA = "0x3279AF0", Offset = "0x3278EF0", Length = "0xCA")]
	[Token(Token = "0x6001F32")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6001F2B")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x3279CA0", Offset = "0x32790A0", Length = "0x42")]
	[Token(Token = "0x6001F29")]
	public override Cursor get_value() { }

	[Address(RVA = "0x3279BC0", Offset = "0x3278FC0", Length = "0x1F")]
	[Token(Token = "0x6001F33")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3279CF0", Offset = "0x32790F0", Length = "0x63")]
	[Token(Token = "0x6001F2F")]
	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	[Address(RVA = "0x3279D60", Offset = "0x3279160", Length = "0x5D")]
	[Token(Token = "0x6001F30")]
	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6001F2C")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3279DC0", Offset = "0x32791C0", Length = "0x2D")]
	[Token(Token = "0x6001F2A")]
	public override void set_value(Cursor value) { }

	[Address(RVA = "0x3279BE0", Offset = "0x3278FE0", Length = "0x68")]
	[Token(Token = "0x6001F34")]
	public virtual string ToString() { }

}


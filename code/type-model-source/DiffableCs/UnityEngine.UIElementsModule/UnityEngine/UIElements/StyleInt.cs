namespace UnityEngine.UIElements;

[Token(Token = "0x2000422")]
public struct StyleInt : IStyleValue<Int32>, IEquatable<StyleInt>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DC4")]
	private int m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000DC5")]
	private StyleKeyword m_Keyword; //Field offset: 0x4

	[Token(Token = "0x170008C4")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6001F84")]
		 get { } //Length: 6
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001F85")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008C3")]
	public override int value
	{
		[Address(RVA = "0xFD3E50", Offset = "0xFD3250", Length = "0xC")]
		[Token(Token = "0x6001F82")]
		 get { } //Length: 12
		[Address(RVA = "0xFD4710", Offset = "0xFD3B10", Length = "0xA")]
		[Token(Token = "0x6001F83")]
		 set { } //Length: 10
	}

	[Address(RVA = "0x3279F40", Offset = "0x3279340", Length = "0xA")]
	[Token(Token = "0x6001F86")]
	public StyleInt(StyleKeyword keyword) { }

	[Address(RVA = "0xFD3C10", Offset = "0xFD3010", Length = "0x7")]
	[Token(Token = "0x6001F87")]
	internal StyleInt(int v, StyleKeyword keyword) { }

	[Address(RVA = "0x327A7D0", Offset = "0x3279BD0", Length = "0x22")]
	[Token(Token = "0x6001F8A")]
	public override bool Equals(StyleInt other) { }

	[Address(RVA = "0x327A730", Offset = "0x3279B30", Length = "0x98")]
	[Token(Token = "0x6001F8B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6001F84")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0xFD3E50", Offset = "0xFD3250", Length = "0xC")]
	[Token(Token = "0x6001F82")]
	public override int get_value() { }

	[Address(RVA = "0x30C55D0", Offset = "0x30C49D0", Length = "0xC")]
	[Token(Token = "0x6001F8C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327A860", Offset = "0x3279C60", Length = "0x1C")]
	[Token(Token = "0x6001F88")]
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	[Address(RVA = "0x3279FB0", Offset = "0x32793B0", Length = "0x12")]
	[Token(Token = "0x6001F89")]
	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001F85")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0xFD4710", Offset = "0xFD3B10", Length = "0xA")]
	[Token(Token = "0x6001F83")]
	public override void set_value(int value) { }

	[Address(RVA = "0x327A800", Offset = "0x3279C00", Length = "0x5F")]
	[Token(Token = "0x6001F8D")]
	public virtual string ToString() { }

}


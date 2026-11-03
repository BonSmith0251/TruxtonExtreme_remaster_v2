namespace UnityEngine.UIElements;

[Token(Token = "0x2000419")]
public struct StyleBackgroundSize : IStyleValue<BackgroundSize>, IEquatable<StyleBackgroundSize>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DB1")]
	private BackgroundSize m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000DB2")]
	private StyleKeyword m_Keyword; //Field offset: 0x14

	[Token(Token = "0x170008B5")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
		[Token(Token = "0x6001F11")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6001F12")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008B4")]
	public override BackgroundSize value
	{
		[Address(RVA = "0x3279010", Offset = "0x3278410", Length = "0x25")]
		[Token(Token = "0x6001F0F")]
		 get { } //Length: 37
		[Address(RVA = "0x3279110", Offset = "0x3278510", Length = "0x14")]
		[Token(Token = "0x6001F10")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x3279000", Offset = "0x3278400", Length = "0xF")]
	[Token(Token = "0x6001F13")]
	public StyleBackgroundSize(StyleKeyword keyword) { }

	[Address(RVA = "0x3278FE0", Offset = "0x32783E0", Length = "0x11")]
	[Token(Token = "0x6001F14")]
	internal StyleBackgroundSize(BackgroundSize v, StyleKeyword keyword) { }

	[Address(RVA = "0x3278EB0", Offset = "0x32782B0", Length = "0x9E")]
	[Token(Token = "0x6001F17")]
	public override bool Equals(StyleBackgroundSize other) { }

	[Address(RVA = "0x3278D90", Offset = "0x3278190", Length = "0x117")]
	[Token(Token = "0x6001F18")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
	[Token(Token = "0x6001F11")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x3279010", Offset = "0x3278410", Length = "0x25")]
	[Token(Token = "0x6001F0F")]
	public override BackgroundSize get_value() { }

	[Address(RVA = "0x3278F50", Offset = "0x3278350", Length = "0x1F")]
	[Token(Token = "0x6001F19")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3279040", Offset = "0x3278440", Length = "0x9E")]
	[Token(Token = "0x6001F15")]
	public static bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	[Address(RVA = "0x32790E0", Offset = "0x32784E0", Length = "0x27")]
	[Token(Token = "0x6001F16")]
	public static StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6001F12")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3279110", Offset = "0x3278510", Length = "0x14")]
	[Token(Token = "0x6001F10")]
	public override void set_value(BackgroundSize value) { }

	[Address(RVA = "0x3278F70", Offset = "0x3278370", Length = "0x6A")]
	[Token(Token = "0x6001F1A")]
	public virtual string ToString() { }

}


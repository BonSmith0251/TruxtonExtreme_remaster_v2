namespace UnityEngine.UIElements;

[Token(Token = "0x200041E")]
public struct StyleEnum : IStyleValue<T>, IEquatable<StyleEnum`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DBC")]
	private T m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DBD")]
	private StyleKeyword m_Keyword; //Field offset: 0x0

	[Token(Token = "0x170008BC")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6001F48")]
		 get { } //Length: 6
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001F49")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008BB")]
	public override T value
	{
		[Address(RVA = "0xFD3E50", Offset = "0xFD3250", Length = "0xC")]
		[Token(Token = "0x6001F46")]
		 get { } //Length: 12
		[Address(RVA = "0xFD4710", Offset = "0xFD3B10", Length = "0xA")]
		[Token(Token = "0x6001F47")]
		 set { } //Length: 10
	}

	[Address(RVA = "0xFD3AA0", Offset = "0xFD2EA0", Length = "0x35")]
	[Token(Token = "0x6001F4A")]
	public StyleEnum`1(T v) { }

	[Address(RVA = "0xFD3A60", Offset = "0xFD2E60", Length = "0x35")]
	[Token(Token = "0x6001F4B")]
	public StyleEnum`1(StyleKeyword keyword) { }

	[Address(RVA = "0xFD3C10", Offset = "0xFD3010", Length = "0x7")]
	[Token(Token = "0x6001F4C")]
	internal StyleEnum`1(T v, StyleKeyword keyword) { }

	[Address(RVA = "0xFD3190", Offset = "0xFD2590", Length = "0x73")]
	[Token(Token = "0x6001F51")]
	public override bool Equals(StyleEnum<T> other) { }

	[Address(RVA = "0xFD3210", Offset = "0xFD2610", Length = "0x100")]
	[Token(Token = "0x6001F52")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6001F48")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0xFD3E50", Offset = "0xFD3250", Length = "0xC")]
	[Token(Token = "0x6001F46")]
	public override T get_value() { }

	[Address(RVA = "0xFD3650", Offset = "0xFD2A50", Length = "0x4F")]
	[Token(Token = "0x6001F53")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xFD4110", Offset = "0xFD3510", Length = "0x4E")]
	[Token(Token = "0x6001F4D")]
	public static bool op_Equality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }

	[Address(RVA = "0xFD4160", Offset = "0xFD3560", Length = "0x51")]
	[Token(Token = "0x6001F4F")]
	public static StyleEnum<T> op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0xFD4480", Offset = "0xFD3880", Length = "0x51")]
	[Token(Token = "0x6001F50")]
	public static StyleEnum<T> op_Implicit(T v) { }

	[Address(RVA = "0xFD44E0", Offset = "0xFD38E0", Length = "0x76")]
	[Token(Token = "0x6001F4E")]
	public static bool op_Inequality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001F49")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0xFD4710", Offset = "0xFD3B10", Length = "0xA")]
	[Token(Token = "0x6001F47")]
	public override void set_value(T value) { }

	[Address(RVA = "0xFD37A0", Offset = "0xFD2BA0", Length = "0x74")]
	[Token(Token = "0x6001F54")]
	public virtual string ToString() { }

}


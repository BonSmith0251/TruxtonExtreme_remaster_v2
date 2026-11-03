namespace UnityEngine.UIElements;

[Token(Token = "0x2000424")]
public struct StyleList : IStyleValue<List`1<T>>, IEquatable<StyleList`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DC8")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DC9")]
	private List<T> m_Value; //Field offset: 0x0

	[Token(Token = "0x170008C8")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6001FA0")]
		 get { } //Length: 5
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6001FA1")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170008C7")]
	public override List<T> value
	{
		[Address(RVA = "0xFD6380", Offset = "0xFD5780", Length = "0xD")]
		[Token(Token = "0x6001F9E")]
		 get { } //Length: 13
		[Address(RVA = "0xFD6940", Offset = "0xFD5D40", Length = "0x22")]
		[Token(Token = "0x6001F9F")]
		 set { } //Length: 34
	}

	[Address(RVA = "0xFD6330", Offset = "0xFD5730", Length = "0x40")]
	[Token(Token = "0x6001FA2")]
	public StyleList`1(StyleKeyword keyword) { }

	[Address(RVA = "0xFD6290", Offset = "0xFD5690", Length = "0x10")]
	[Token(Token = "0x6001FA3")]
	internal StyleList`1(List<T> v, StyleKeyword keyword) { }

	[Address(RVA = "0xFD5110", Offset = "0xFD4510", Length = "0xE7")]
	[Token(Token = "0x6001FA6")]
	public override bool Equals(StyleList<T> other) { }

	[Address(RVA = "0xFD4A60", Offset = "0xFD3E60", Length = "0x107")]
	[Token(Token = "0x6001FA7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001FA0")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0xFD6380", Offset = "0xFD5780", Length = "0xD")]
	[Token(Token = "0x6001F9E")]
	public override List<T> get_value() { }

	[Address(RVA = "0xFD5AF0", Offset = "0xFD4EF0", Length = "0x2B8")]
	[Token(Token = "0x6001FA8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xFD6390", Offset = "0xFD5790", Length = "0xB2")]
	[Token(Token = "0x6001FA4")]
	public static bool op_Equality(StyleList<T> lhs, StyleList<T> rhs) { }

	[Address(RVA = "0xFD6800", Offset = "0xFD5C00", Length = "0x7B")]
	[Token(Token = "0x6001FA5")]
	public static StyleList<T> op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001FA1")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0xFD6940", Offset = "0xFD5D40", Length = "0x22")]
	[Token(Token = "0x6001F9F")]
	public override void set_value(List<T> value) { }

	[Address(RVA = "0xFD6160", Offset = "0xFD5560", Length = "0x77")]
	[Token(Token = "0x6001FA9")]
	public virtual string ToString() { }

}


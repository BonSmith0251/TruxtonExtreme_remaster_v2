namespace UnityEngine.UIElements;

[Token(Token = "0x2000429")]
public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DD2")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000DD3")]
	private TextShadow m_Value; //Field offset: 0x4

	[Token(Token = "0x170008D2")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6001FE7")]
		 get { } //Length: 5
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6001FE8")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170008D1")]
	public override TextShadow value
	{
		[Address(RVA = "0x327C0C0", Offset = "0x327B4C0", Length = "0x4B")]
		[Token(Token = "0x6001FE5")]
		 get { } //Length: 75
		[Address(RVA = "0x327C200", Offset = "0x327B600", Length = "0x1E")]
		[Token(Token = "0x6001FE6")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x327C070", Offset = "0x327B470", Length = "0x27")]
	[Token(Token = "0x6001FE9")]
	public StyleTextShadow(StyleKeyword keyword) { }

	[Address(RVA = "0x327C0A0", Offset = "0x327B4A0", Length = "0x1B")]
	[Token(Token = "0x6001FEA")]
	internal StyleTextShadow(TextShadow v, StyleKeyword keyword) { }

	[Address(RVA = "0x327BF10", Offset = "0x327B310", Length = "0xAE")]
	[Token(Token = "0x6001FED")]
	public override bool Equals(StyleTextShadow other) { }

	[Address(RVA = "0x327BDE0", Offset = "0x327B1E0", Length = "0x12A")]
	[Token(Token = "0x6001FEE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001FE7")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327C0C0", Offset = "0x327B4C0", Length = "0x4B")]
	[Token(Token = "0x6001FE5")]
	public override TextShadow get_value() { }

	[Address(RVA = "0x327BFC0", Offset = "0x327B3C0", Length = "0x3B")]
	[Token(Token = "0x6001FEF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327C110", Offset = "0x327B510", Length = "0xAE")]
	[Token(Token = "0x6001FEB")]
	public static bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	[Address(RVA = "0x327C1C0", Offset = "0x327B5C0", Length = "0x40")]
	[Token(Token = "0x6001FEC")]
	public static StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001FE8")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x327C200", Offset = "0x327B600", Length = "0x1E")]
	[Token(Token = "0x6001FE6")]
	public override void set_value(TextShadow value) { }

	[Address(RVA = "0x327C000", Offset = "0x327B400", Length = "0x68")]
	[Token(Token = "0x6001FF0")]
	public virtual string ToString() { }

}


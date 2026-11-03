namespace UnityEngine.UIElements;

[Token(Token = "0x200041F")]
public struct StyleFloat : IStyleValue<Single>, IEquatable<StyleFloat>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DBE")]
	private float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000DBF")]
	private StyleKeyword m_Keyword; //Field offset: 0x4

	[Token(Token = "0x170008BE")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6001F57")]
		 get { } //Length: 6
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001F58")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008BD")]
	public override float value
	{
		[Address(RVA = "0x3279F50", Offset = "0x3279350", Length = "0xF")]
		[Token(Token = "0x6001F55")]
		 get { } //Length: 15
		[Address(RVA = "0x3279F30", Offset = "0x3279330", Length = "0xC")]
		[Token(Token = "0x6001F56")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x3279F30", Offset = "0x3279330", Length = "0xC")]
	[Token(Token = "0x6001F59")]
	public StyleFloat(float v) { }

	[Address(RVA = "0x3279F40", Offset = "0x3279340", Length = "0xA")]
	[Token(Token = "0x6001F5A")]
	public StyleFloat(StyleKeyword keyword) { }

	[Address(RVA = "0x12F1440", Offset = "0x12F0840", Length = "0x9")]
	[Token(Token = "0x6001F5B")]
	internal StyleFloat(float v, StyleKeyword keyword) { }

	[Address(RVA = "0x3279EA0", Offset = "0x32792A0", Length = "0x2E")]
	[Token(Token = "0x6001F5F")]
	public override bool Equals(StyleFloat other) { }

	[Address(RVA = "0x3279DF0", Offset = "0x32791F0", Length = "0xAA")]
	[Token(Token = "0x6001F60")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6001F57")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x3279F50", Offset = "0x3279350", Length = "0xF")]
	[Token(Token = "0x6001F55")]
	public override float get_value() { }

	[Address(RVA = "0x322F010", Offset = "0x322E410", Length = "0x1F")]
	[Token(Token = "0x6001F61")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3279F60", Offset = "0x3279360", Length = "0x2B")]
	[Token(Token = "0x6001F5C")]
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	[Address(RVA = "0x3279FB0", Offset = "0x32793B0", Length = "0x12")]
	[Token(Token = "0x6001F5D")]
	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x3279F90", Offset = "0x3279390", Length = "0x14")]
	[Token(Token = "0x6001F5E")]
	public static StyleFloat op_Implicit(float v) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001F58")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x3279F30", Offset = "0x3279330", Length = "0xC")]
	[Token(Token = "0x6001F56")]
	public override void set_value(float value) { }

	[Address(RVA = "0x3279ED0", Offset = "0x32792D0", Length = "0x5F")]
	[Token(Token = "0x6001F62")]
	public virtual string ToString() { }

}


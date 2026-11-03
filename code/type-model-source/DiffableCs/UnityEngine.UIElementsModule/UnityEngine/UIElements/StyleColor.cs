namespace UnityEngine.UIElements;

[Token(Token = "0x200041A")]
public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DB3")]
	private Color m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000DB4")]
	private StyleKeyword m_Keyword; //Field offset: 0x10

	[Token(Token = "0x170008B7")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x6001F1D")]
		 get { } //Length: 6
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6001F1E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008B6")]
	public override Color value
	{
		[Address(RVA = "0x32799B0", Offset = "0x3278DB0", Length = "0x1A")]
		[Token(Token = "0x6001F1B")]
		 get { } //Length: 26
		[Address(RVA = "0x1F87700", Offset = "0x1F86B00", Length = "0xE")]
		[Token(Token = "0x6001F1C")]
		 set { } //Length: 14
	}

	[Address(RVA = "0x1F87700", Offset = "0x1F86B00", Length = "0xE")]
	[Token(Token = "0x6001F1F")]
	public StyleColor(Color v) { }

	[Address(RVA = "0x32799A0", Offset = "0x3278DA0", Length = "0xA")]
	[Token(Token = "0x6001F20")]
	public StyleColor(StyleKeyword keyword) { }

	[Address(RVA = "0xAEE4F0", Offset = "0xAED8F0", Length = "0xB")]
	[Token(Token = "0x6001F21")]
	internal StyleColor(Color v, StyleKeyword keyword) { }

	[Address(RVA = "0x3279730", Offset = "0x3278B30", Length = "0x7F")]
	[Token(Token = "0x6001F25")]
	public override bool Equals(StyleColor other) { }

	[Address(RVA = "0x32797B0", Offset = "0x3278BB0", Length = "0xFA")]
	[Token(Token = "0x6001F26")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6001F1D")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x32799B0", Offset = "0x3278DB0", Length = "0x1A")]
	[Token(Token = "0x6001F1B")]
	public override Color get_value() { }

	[Address(RVA = "0x32798B0", Offset = "0x3278CB0", Length = "0x74")]
	[Token(Token = "0x6001F27")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32799D0", Offset = "0x3278DD0", Length = "0x7F")]
	[Token(Token = "0x6001F22")]
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	[Address(RVA = "0x3279A50", Offset = "0x3278E50", Length = "0xD")]
	[Token(Token = "0x6001F23")]
	public static StyleColor op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x3279A60", Offset = "0x3278E60", Length = "0x17")]
	[Token(Token = "0x6001F24")]
	public static StyleColor op_Implicit(Color v) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6001F1E")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1F87700", Offset = "0x1F86B00", Length = "0xE")]
	[Token(Token = "0x6001F1C")]
	public override void set_value(Color value) { }

	[Address(RVA = "0x3279930", Offset = "0x3278D30", Length = "0x66")]
	[Token(Token = "0x6001F28")]
	public virtual string ToString() { }

}


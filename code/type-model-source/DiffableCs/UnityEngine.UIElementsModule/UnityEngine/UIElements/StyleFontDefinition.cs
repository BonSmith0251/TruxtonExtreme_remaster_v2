namespace UnityEngine.UIElements;

[Token(Token = "0x2000421")]
public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DC2")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000DC3")]
	private FontDefinition m_Value; //Field offset: 0x8

	[Token(Token = "0x170008C2")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6001F73")]
		 get { } //Length: 5
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6001F74")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170008C1")]
	public override FontDefinition value
	{
		[Address(RVA = "0x327A2B0", Offset = "0x32796B0", Length = "0x1A")]
		[Token(Token = "0x6001F71")]
		 get { } //Length: 26
		[Address(RVA = "0x327A370", Offset = "0x3279770", Length = "0x27")]
		[Token(Token = "0x6001F72")]
		 set { } //Length: 39
	}

	[Address(RVA = "0x327A230", Offset = "0x3279630", Length = "0x3B")]
	[Token(Token = "0x6001F79")]
	internal StyleFontDefinition(object obj, StyleKeyword keyword) { }

	[Address(RVA = "0x327A110", Offset = "0x3279510", Length = "0x15")]
	[Token(Token = "0x6001F7C")]
	internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword) { }

	[Address(RVA = "0x327A190", Offset = "0x3279590", Length = "0x18")]
	[Token(Token = "0x6001F75")]
	public StyleFontDefinition(FontDefinition f) { }

	[Address(RVA = "0x327A150", Offset = "0x3279550", Length = "0x33")]
	[Token(Token = "0x6001F76")]
	public StyleFontDefinition(FontAsset f) { }

	[Address(RVA = "0x327A1F0", Offset = "0x32795F0", Length = "0x33")]
	[Token(Token = "0x6001F77")]
	public StyleFontDefinition(Font f) { }

	[Address(RVA = "0x327A130", Offset = "0x3279530", Length = "0x14")]
	[Token(Token = "0x6001F78")]
	public StyleFontDefinition(StyleKeyword keyword) { }

	[Address(RVA = "0x327A1B0", Offset = "0x32795B0", Length = "0x3B")]
	[Token(Token = "0x6001F7A")]
	internal StyleFontDefinition(FontAsset f, StyleKeyword keyword) { }

	[Address(RVA = "0x327A270", Offset = "0x3279670", Length = "0x3B")]
	[Token(Token = "0x6001F7B")]
	internal StyleFontDefinition(Font f, StyleKeyword keyword) { }

	[Address(RVA = "0x327A090", Offset = "0x3279490", Length = "0x4F")]
	[Token(Token = "0x6001F7F")]
	public override bool Equals(StyleFontDefinition other) { }

	[Address(RVA = "0x3279FD0", Offset = "0x32793D0", Length = "0xB7")]
	[Token(Token = "0x6001F80")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001F73")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327A2B0", Offset = "0x32796B0", Length = "0x1A")]
	[Token(Token = "0x6001F71")]
	public override FontDefinition get_value() { }

	[Address(RVA = "0x327A0E0", Offset = "0x32794E0", Length = "0x21")]
	[Token(Token = "0x6001F81")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327A2D0", Offset = "0x32796D0", Length = "0x4A")]
	[Token(Token = "0x6001F7D")]
	public static StyleFontDefinition op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x327A320", Offset = "0x3279720", Length = "0x4A")]
	[Token(Token = "0x6001F7E")]
	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001F74")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x327A370", Offset = "0x3279770", Length = "0x27")]
	[Token(Token = "0x6001F72")]
	public override void set_value(FontDefinition value) { }

}


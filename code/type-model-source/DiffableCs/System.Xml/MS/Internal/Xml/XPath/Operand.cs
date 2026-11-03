namespace MS.Internal.Xml.XPath;

[Token(Token = "0x200027A")]
internal class Operand : AstNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E07")]
	private XPathResultType _type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E08")]
	private object _val; //Field offset: 0x18

	[Token(Token = "0x170006A6")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600199C")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170006A5")]
	public virtual AstType Type
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x600199B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x24D7750", Offset = "0x24D6B50", Length = "0x38")]
	[Token(Token = "0x6001999")]
	public Operand(string val) { }

	[Address(RVA = "0x24D7790", Offset = "0x24D6B90", Length = "0x51")]
	[Token(Token = "0x600199A")]
	public Operand(double val) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600199C")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x600199B")]
	public virtual AstType get_Type() { }

}


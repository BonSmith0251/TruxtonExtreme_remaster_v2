namespace MS.Internal.Xml.XPath;

[Token(Token = "0x2000276")]
internal class Filter : AstNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DE2")]
	private AstNode _input; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DE3")]
	private AstNode _condition; //Field offset: 0x18

	[Token(Token = "0x170006A0")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x600198F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700069F")]
	public virtual AstType Type
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600198E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600198D")]
	public Filter(AstNode input, AstNode condition) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x600198F")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600198E")]
	public virtual AstType get_Type() { }

}


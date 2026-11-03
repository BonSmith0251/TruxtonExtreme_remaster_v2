namespace MS.Internal.Xml.XPath;

[Token(Token = "0x200027D")]
internal class Root : AstNode
{

	[Token(Token = "0x170006AA")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x60019A3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170006A9")]
	public virtual AstType Type
	{
		[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
		[Token(Token = "0x60019A2")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60019A1")]
	public Root() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x60019A3")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x60019A2")]
	public virtual AstType get_Type() { }

}


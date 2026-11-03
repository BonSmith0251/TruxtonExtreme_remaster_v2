namespace MS.Internal.Xml.XPath;

[Token(Token = "0x200027E")]
internal class Variable : AstNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E1D")]
	private string _localname; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E1E")]
	private string _prefix; //Field offset: 0x18

	[Token(Token = "0x170006AC")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
		[Token(Token = "0x60019A6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170006AB")]
	public virtual AstType Type
	{
		[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
		[Token(Token = "0x60019A5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60019A4")]
	public Variable(string name, string prefix) { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x60019A6")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
	[Token(Token = "0x60019A5")]
	public virtual AstType get_Type() { }

}


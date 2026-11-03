namespace MS.Internal.Xml.XPath;

[Token(Token = "0x2000279")]
internal class Group : AstNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E06")]
	private AstNode _groupNode; //Field offset: 0x10

	[Token(Token = "0x170006A4")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6001998")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170006A3")]
	public virtual AstType Type
	{
		[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
		[Token(Token = "0x6001997")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001996")]
	public Group(AstNode groupNode) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6001998")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x6001997")]
	public virtual AstType get_Type() { }

}


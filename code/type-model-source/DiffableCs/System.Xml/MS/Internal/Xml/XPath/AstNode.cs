namespace MS.Internal.Xml.XPath;

[Token(Token = "0x2000272")]
internal abstract class AstNode
{
	[Token(Token = "0x2000273")]
	internal enum AstType : int
	{
		Axis = 0,
		Operator = 1,
		Filter = 2,
		ConstantOperand = 3,
		Function = 4,
		Group = 5,
		Root = 6,
		Variable = 7,
		Error = 8,
	}


	[Token(Token = "0x17000695")]
	public abstract XPathResultType ReturnType
	{
		[Token(Token = "0x600197E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000694")]
	public abstract AstType Type
	{
		[Token(Token = "0x600197D")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600197F")]
	protected AstNode() { }

	[Token(Token = "0x600197E")]
	public abstract XPathResultType get_ReturnType() { }

	[Token(Token = "0x600197D")]
	public abstract AstType get_Type() { }

}


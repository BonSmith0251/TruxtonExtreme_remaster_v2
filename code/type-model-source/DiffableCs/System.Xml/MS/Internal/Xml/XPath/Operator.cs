namespace MS.Internal.Xml.XPath;

[Token(Token = "0x200027B")]
internal class Operator : AstNode
{
	[Token(Token = "0x200027C")]
	internal enum Op : int
	{
		INVALID = 0,
		OR = 1,
		AND = 2,
		EQ = 3,
		NE = 4,
		LT = 5,
		LE = 6,
		GT = 7,
		GE = 8,
		PLUS = 9,
		MINUS = 10,
		MUL = 11,
		DIV = 12,
		MOD = 13,
		UNION = 14,
	}

	[Token(Token = "0x4000E09")]
	private static Op[] s_invertOp; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E0A")]
	private Op _opType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E0B")]
	private AstNode _opnd1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E0C")]
	private AstNode _opnd2; //Field offset: 0x20

	[Token(Token = "0x170006A8")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x24D7880", Offset = "0x24D6C80", Length = "0x1B")]
		[Token(Token = "0x600199F")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170006A7")]
	public virtual AstType Type
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600199E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x24D77F0", Offset = "0x24D6BF0", Length = "0x8C")]
	[Token(Token = "0x60019A0")]
	private static Operator() { }

	[Address(RVA = "0x19529A0", Offset = "0x1951DA0", Length = "0x5D")]
	[Token(Token = "0x600199D")]
	public Operator(Op op, AstNode opnd1, AstNode opnd2) { }

	[Address(RVA = "0x24D7880", Offset = "0x24D6C80", Length = "0x1B")]
	[Token(Token = "0x600199F")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600199E")]
	public virtual AstType get_Type() { }

}


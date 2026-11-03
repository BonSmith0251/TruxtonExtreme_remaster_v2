namespace MS.Internal.Xml.XPath;

[Token(Token = "0x2000277")]
internal class Function : AstNode
{
	[Token(Token = "0x2000278")]
	internal enum FunctionType : int
	{
		FuncLast = 0,
		FuncPosition = 1,
		FuncCount = 2,
		FuncID = 3,
		FuncLocalName = 4,
		FuncNameSpaceUri = 5,
		FuncName = 6,
		FuncString = 7,
		FuncBoolean = 8,
		FuncNumber = 9,
		FuncTrue = 10,
		FuncFalse = 11,
		FuncNot = 12,
		FuncConcat = 13,
		FuncStartsWith = 14,
		FuncContains = 15,
		FuncSubstringBefore = 16,
		FuncSubstringAfter = 17,
		FuncSubstring = 18,
		FuncStringLength = 19,
		FuncNormalize = 20,
		FuncTranslate = 21,
		FuncLang = 22,
		FuncSum = 23,
		FuncFloor = 24,
		FuncCeiling = 25,
		FuncRound = 26,
		FuncUserDefined = 27,
	}

	[Token(Token = "0x4000DE8")]
	internal static XPathResultType[] ReturnTypes; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DE4")]
	private FunctionType _functionType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DE5")]
	private List<AstNode> _argumentList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DE6")]
	private string _name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DE7")]
	private string _prefix; //Field offset: 0x28

	[Token(Token = "0x170006A2")]
	public virtual XPathResultType ReturnType
	{
		[Address(RVA = "0x24D76D0", Offset = "0x24D6AD0", Length = "0x71")]
		[Token(Token = "0x6001994")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170006A1")]
	public virtual AstType Type
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6001993")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x24D73E0", Offset = "0x24D67E0", Length = "0x8C")]
	[Token(Token = "0x6001995")]
	private static Function() { }

	[Address(RVA = "0x24D7580", Offset = "0x24D6980", Length = "0x8C")]
	[Token(Token = "0x6001990")]
	public Function(FunctionType ftype, List<AstNode> argumentList) { }

	[Address(RVA = "0x24D7610", Offset = "0x24D6A10", Length = "0xBE")]
	[Token(Token = "0x6001991")]
	public Function(string prefix, string name, List<AstNode> argumentList) { }

	[Address(RVA = "0x24D7470", Offset = "0x24D6870", Length = "0x10D")]
	[Token(Token = "0x6001992")]
	public Function(FunctionType ftype, AstNode arg) { }

	[Address(RVA = "0x24D76D0", Offset = "0x24D6AD0", Length = "0x71")]
	[Token(Token = "0x6001994")]
	public virtual XPathResultType get_ReturnType() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6001993")]
	public virtual AstType get_Type() { }

}


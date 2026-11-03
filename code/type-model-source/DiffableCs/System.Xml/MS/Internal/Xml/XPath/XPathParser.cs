namespace MS.Internal.Xml.XPath;

[Token(Token = "0x200027F")]
internal class XPathParser
{
	[Token(Token = "0x2000280")]
	private class ParamInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E2C")]
		private FunctionType _ftype; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000E2D")]
		private int _minargs; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E2E")]
		private int _maxargs; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000E2F")]
		private XPathResultType[] _argTypes; //Field offset: 0x20

		[Token(Token = "0x170006B0")]
		public XPathResultType[] ArgTypes
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60019CA")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170006AD")]
		public FunctionType FType
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x60019C7")]
			 get { } //Length: 85
		}

		[Token(Token = "0x170006AF")]
		public int Maxargs
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x60019C9")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170006AE")]
		public int Minargs
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x60019C8")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x24D78A0", Offset = "0x24D6CA0", Length = "0x55")]
		[Token(Token = "0x60019CB")]
		internal ParamInfo(FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60019CA")]
		public XPathResultType[] get_ArgTypes() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60019C7")]
		public FunctionType get_FType() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60019C9")]
		public int get_Maxargs() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60019C8")]
		public int get_Minargs() { }

	}

	[Token(Token = "0x4000E21")]
	private static readonly XPathResultType[] s_temparray1; //Field offset: 0x0
	[Token(Token = "0x4000E22")]
	private static readonly XPathResultType[] s_temparray2; //Field offset: 0x8
	[Token(Token = "0x4000E23")]
	private static readonly XPathResultType[] s_temparray3; //Field offset: 0x10
	[Token(Token = "0x4000E24")]
	private static readonly XPathResultType[] s_temparray4; //Field offset: 0x18
	[Token(Token = "0x4000E25")]
	private static readonly XPathResultType[] s_temparray5; //Field offset: 0x20
	[Token(Token = "0x4000E26")]
	private static readonly XPathResultType[] s_temparray6; //Field offset: 0x28
	[Token(Token = "0x4000E27")]
	private static readonly XPathResultType[] s_temparray7; //Field offset: 0x30
	[Token(Token = "0x4000E28")]
	private static readonly XPathResultType[] s_temparray8; //Field offset: 0x38
	[Token(Token = "0x4000E29")]
	private static readonly XPathResultType[] s_temparray9; //Field offset: 0x40
	[Token(Token = "0x4000E2A")]
	private static Dictionary<String, ParamInfo> s_functionTable; //Field offset: 0x48
	[Token(Token = "0x4000E2B")]
	private static Dictionary<String, AxisType> s_AxesTable; //Field offset: 0x50
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E1F")]
	private XPathScanner _scanner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E20")]
	private int _parseDepth; //Field offset: 0x18

	[Address(RVA = "0x24DE720", Offset = "0x24DDB20", Length = "0x3F0")]
	[Token(Token = "0x60019C6")]
	private static XPathParser() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60019A7")]
	private XPathParser(XPathScanner scanner) { }

	[Address(RVA = "0x24DAB90", Offset = "0x24D9F90", Length = "0x6A")]
	[Token(Token = "0x60019C2")]
	private void CheckNodeSet(XPathResultType t) { }

	[Address(RVA = "0x24DAC00", Offset = "0x24DA000", Length = "0x72")]
	[Token(Token = "0x60019BE")]
	private void CheckToken(LexKind t) { }

	[Address(RVA = "0x24DAC80", Offset = "0x24DA080", Length = "0x27D")]
	[Token(Token = "0x60019C4")]
	private static Dictionary<String, AxisType> CreateAxesTable() { }

	[Address(RVA = "0x24DAF00", Offset = "0x24DA300", Length = "0xCC6")]
	[Token(Token = "0x60019C3")]
	private static Dictionary<String, ParamInfo> CreateFunctionTable() { }

	[Address(RVA = "0x24DBBD0", Offset = "0x24DAFD0", Length = "0xE7")]
	[Token(Token = "0x60019C5")]
	private AxisType GetAxis() { }

	[Address(RVA = "0x24DBCC0", Offset = "0x24DB0C0", Length = "0xCF")]
	[Token(Token = "0x60019B2")]
	private static bool IsNodeType(XPathScanner scaner) { }

	[Address(RVA = "0x24DBD90", Offset = "0x24DB190", Length = "0x8A")]
	[Token(Token = "0x60019BB")]
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	[Address(RVA = "0x24DBE20", Offset = "0x24DB220", Length = "0x22")]
	[Token(Token = "0x60019B8")]
	private static bool IsStep(LexKind lexKind) { }

	[Address(RVA = "0x24DBE50", Offset = "0x24DB250", Length = "0x1D")]
	[Token(Token = "0x60019C0")]
	private void NextLex() { }

	[Address(RVA = "0x24DBE70", Offset = "0x24DB270", Length = "0x114")]
	[Token(Token = "0x60019AE")]
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DBF90", Offset = "0x24DB390", Length = "0x157")]
	[Token(Token = "0x60019AB")]
	private AstNode ParseAndExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DC0F0", Offset = "0x24DB4F0", Length = "0x114")]
	[Token(Token = "0x60019AC")]
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DC210", Offset = "0x24DB610", Length = "0x19B")]
	[Token(Token = "0x60019A9")]
	private AstNode ParseExpression(AstNode qyInput) { }

	[Address(RVA = "0x24DC3B0", Offset = "0x24DB7B0", Length = "0xCB")]
	[Token(Token = "0x60019B4")]
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DC480", Offset = "0x24DB880", Length = "0x154")]
	[Token(Token = "0x60019B6")]
	private AstNode ParseLocationPath(AstNode qyInput) { }

	[Address(RVA = "0x24DC5E0", Offset = "0x24DB9E0", Length = "0x858")]
	[Token(Token = "0x60019BD")]
	private AstNode ParseMethod(AstNode qyInput) { }

	[Address(RVA = "0x24DCE40", Offset = "0x24DC240", Length = "0x1B4")]
	[Token(Token = "0x60019AF")]
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DD000", Offset = "0x24DC400", Length = "0x3E0")]
	[Token(Token = "0x60019BA")]
	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	[Address(RVA = "0x24DD3F0", Offset = "0x24DC7F0", Length = "0x157")]
	[Token(Token = "0x60019AA")]
	private AstNode ParseOrExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DD550", Offset = "0x24DC950", Length = "0x309")]
	[Token(Token = "0x60019B3")]
	private AstNode ParsePathExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DD860", Offset = "0x24DCC60", Length = "0x180")]
	[Token(Token = "0x60019B5")]
	private AstNode ParsePredicate(AstNode qyInput) { }

	[Address(RVA = "0x24DD9F0", Offset = "0x24DCDF0", Length = "0x32F")]
	[Token(Token = "0x60019BC")]
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DDD20", Offset = "0x24DD120", Length = "0x12E")]
	[Token(Token = "0x60019AD")]
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DDE50", Offset = "0x24DD250", Length = "0xD3")]
	[Token(Token = "0x60019B7")]
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	[Address(RVA = "0x24DDF30", Offset = "0x24DD330", Length = "0x27C")]
	[Token(Token = "0x60019B9")]
	private AstNode ParseStep(AstNode qyInput) { }

	[Address(RVA = "0x24DE1B0", Offset = "0x24DD5B0", Length = "0x13F")]
	[Token(Token = "0x60019B0")]
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DE2F0", Offset = "0x24DD6F0", Length = "0x1F6")]
	[Token(Token = "0x60019B1")]
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	[Address(RVA = "0x24DE4F0", Offset = "0x24DD8F0", Length = "0x1AA")]
	[Token(Token = "0x60019A8")]
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	[Address(RVA = "0x24DE6A0", Offset = "0x24DDAA0", Length = "0x2B")]
	[Token(Token = "0x60019BF")]
	private void PassToken(LexKind t) { }

	[Address(RVA = "0x24DE6D0", Offset = "0x24DDAD0", Length = "0x44")]
	[Token(Token = "0x60019C1")]
	private bool TestOp(string op) { }

}


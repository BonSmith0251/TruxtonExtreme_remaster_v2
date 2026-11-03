namespace MS.Internal.Xml.XPath;

[Token(Token = "0x2000281")]
internal sealed class XPathScanner
{
	[Token(Token = "0x2000282")]
	internal enum LexKind : int
	{
		Comma = 44,
		Slash = 47,
		At = 64,
		Dot = 46,
		LParens = 40,
		RParens = 41,
		LBracket = 91,
		RBracket = 93,
		Star = 42,
		Plus = 43,
		Minus = 45,
		Eq = 61,
		Lt = 60,
		Gt = 62,
		Bang = 33,
		Dollar = 36,
		Apos = 39,
		Quote = 34,
		Union = 124,
		Ne = 78,
		Le = 76,
		Ge = 71,
		And = 65,
		Or = 79,
		DotDot = 68,
		SlashSlash = 83,
		Name = 110,
		String = 115,
		Number = 100,
		Axe = 97,
		Eof = 69,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E30")]
	private string _xpathExpr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E31")]
	private int _xpathExprIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000E32")]
	private LexKind _kind; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E33")]
	private char _currentChar; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E34")]
	private string _name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E35")]
	private string _prefix; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E36")]
	private string _stringValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E37")]
	private double _numberValue; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E38")]
	private bool _canBeFunction; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E39")]
	private XmlCharType _xmlCharType; //Field offset: 0x50

	[Token(Token = "0x170006B8")]
	public bool CanBeFunction
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x60019D5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006B2")]
	private char CurrentChar
	{
		[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
		[Token(Token = "0x60019CE")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170006B3")]
	public LexKind Kind
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x60019D0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006B4")]
	public string Name
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60019D1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006B7")]
	public double NumberValue
	{
		[Address(RVA = "0x1116950", Offset = "0x1115D50", Length = "0x6")]
		[Token(Token = "0x60019D4")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170006B5")]
	public string Prefix
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60019D2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006B1")]
	public string SourceText
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60019CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006B6")]
	public string StringValue
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60019D3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x24DF6E0", Offset = "0x24DEAE0", Length = "0xDE")]
	[Token(Token = "0x60019CC")]
	public XPathScanner(string xpathExpr) { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x60019D5")]
	public bool get_CanBeFunction() { }

	[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
	[Token(Token = "0x60019CE")]
	private char get_CurrentChar() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x60019D0")]
	public LexKind get_Kind() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60019D1")]
	public string get_Name() { }

	[Address(RVA = "0x1116950", Offset = "0x1115D50", Length = "0x6")]
	[Token(Token = "0x60019D4")]
	public double get_NumberValue() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60019D2")]
	public string get_Prefix() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60019CD")]
	public string get_SourceText() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60019D3")]
	public string get_StringValue() { }

	[Address(RVA = "0x24DEB20", Offset = "0x24DDF20", Length = "0x51")]
	[Token(Token = "0x60019CF")]
	private bool NextChar() { }

	[Address(RVA = "0x24DEB80", Offset = "0x24DDF80", Length = "0x634")]
	[Token(Token = "0x60019D7")]
	public bool NextLex() { }

	[Address(RVA = "0x24DF200", Offset = "0x24DE600", Length = "0xE5")]
	[Token(Token = "0x60019D9")]
	private double ScanFraction() { }

	[Address(RVA = "0x24DF2F0", Offset = "0x24DE6F0", Length = "0xBB")]
	[Token(Token = "0x60019DB")]
	private string ScanName() { }

	[Address(RVA = "0x24DF3B0", Offset = "0x24DE7B0", Length = "0x175")]
	[Token(Token = "0x60019D8")]
	private double ScanNumber() { }

	[Address(RVA = "0x24DF530", Offset = "0x24DE930", Length = "0x138")]
	[Token(Token = "0x60019DA")]
	private string ScanString() { }

	[Address(RVA = "0x24DF670", Offset = "0x24DEA70", Length = "0x6B")]
	[Token(Token = "0x60019D6")]
	private void SkipSpace() { }

}


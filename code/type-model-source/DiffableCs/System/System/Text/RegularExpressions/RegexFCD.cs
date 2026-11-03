namespace System.Text.RegularExpressions;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000EA")]
internal struct RegexFCD
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003F0")]
	private readonly List<RegexFC> _fcStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003F1")]
	private ValueListBuilder<Int32> _intStack; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003F2")]
	private bool _skipAllChildren; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40003F3")]
	private bool _skipchild; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40003F4")]
	private bool _failed; //Field offset: 0x2A

	[Address(RVA = "0x2623F50", Offset = "0x2623350", Length = "0xC6")]
	[Token(Token = "0x600053E")]
	private RegexFCD(Span<Int32> intStack) { }

	[Address(RVA = "0x2622930", Offset = "0x2621D30", Length = "0x60")]
	[Token(Token = "0x6000542")]
	private static int AnchorFromType(int type) { }

	[Address(RVA = "0x26229B0", Offset = "0x2621DB0", Length = "0x150")]
	[Token(Token = "0x6000541")]
	public static int Anchors(RegexTree tree) { }

	[Address(RVA = "0x2622B70", Offset = "0x2621F70", Length = "0x3A4")]
	[Token(Token = "0x600054D")]
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

	[Address(RVA = "0x2623300", Offset = "0x2622700", Length = "0x3A")]
	[Token(Token = "0x600054A")]
	public void Dispose() { }

	[Address(RVA = "0x2623340", Offset = "0x2622740", Length = "0x3F")]
	[Token(Token = "0x6000547")]
	private bool FCIsEmpty() { }

	[Address(RVA = "0x2623380", Offset = "0x2622780", Length = "0x3DB")]
	[Token(Token = "0x600053F")]
	public static Nullable<RegexPrefix> FirstChars(RegexTree t) { }

	[Address(RVA = "0x2623760", Offset = "0x2622B60", Length = "0x32")]
	[Token(Token = "0x6000544")]
	private bool IntIsEmpty() { }

	[Address(RVA = "0x26237A0", Offset = "0x2622BA0", Length = "0xAC")]
	[Token(Token = "0x6000548")]
	private RegexFC PopFC() { }

	[Address(RVA = "0x2623850", Offset = "0x2622C50", Length = "0x47")]
	[Token(Token = "0x6000545")]
	private int PopInt() { }

	[Address(RVA = "0x26238A0", Offset = "0x2622CA0", Length = "0x230")]
	[Token(Token = "0x6000540")]
	public static RegexPrefix Prefix(RegexTree tree) { }

	[Address(RVA = "0x2623B10", Offset = "0x2622F10", Length = "0xA8")]
	[Token(Token = "0x6000546")]
	private void PushFC(RegexFC fc) { }

	[Address(RVA = "0x2623BC0", Offset = "0x2622FC0", Length = "0xAC")]
	[Token(Token = "0x6000543")]
	private void PushInt(int i) { }

	[Address(RVA = "0x2623C70", Offset = "0x2623070", Length = "0x274")]
	[Token(Token = "0x600054B")]
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	[Address(RVA = "0x25D7420", Offset = "0x25D6820", Length = "0x5")]
	[Token(Token = "0x600054C")]
	private void SkipChild() { }

	[Address(RVA = "0x2623EF0", Offset = "0x26232F0", Length = "0x57")]
	[Token(Token = "0x6000549")]
	private RegexFC TopFC() { }

}


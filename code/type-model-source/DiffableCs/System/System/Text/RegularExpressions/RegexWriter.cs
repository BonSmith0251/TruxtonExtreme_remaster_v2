namespace System.Text.RegularExpressions;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000F6")]
internal struct RegexWriter
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400044D")]
	private ValueListBuilder<Int32> _emitted; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400044E")]
	private ValueListBuilder<Int32> _intStack; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400044F")]
	private readonly Dictionary<String, Int32> _stringHash; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000450")]
	private readonly List<String> _stringTable; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000451")]
	private Hashtable _caps; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000452")]
	private int _trackCount; //Field offset: 0x58

	[Address(RVA = "0x263CE40", Offset = "0x263C240", Length = "0x13C")]
	[Token(Token = "0x600060A")]
	private RegexWriter(Span<Int32> emittedSpan, Span<Int32> intStackSpan) { }

	[Address(RVA = "0x263B810", Offset = "0x263AC10", Length = "0x49")]
	[Token(Token = "0x600060C")]
	public void Dispose() { }

	[Address(RVA = "0x263C2C0", Offset = "0x263B6C0", Length = "0x56")]
	[Token(Token = "0x600060F")]
	private void Emit(int op) { }

	[Address(RVA = "0x263C240", Offset = "0x263B640", Length = "0x74")]
	[Token(Token = "0x6000610")]
	private void Emit(int op, int opd1) { }

	[Address(RVA = "0x263C320", Offset = "0x263B720", Length = "0x92")]
	[Token(Token = "0x6000611")]
	private void Emit(int op, int opd1, int opd2) { }

	[Address(RVA = "0x263B860", Offset = "0x263AC60", Length = "0x938")]
	[Token(Token = "0x6000614")]
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

	[Address(RVA = "0x263C3C0", Offset = "0x263B7C0", Length = "0x94")]
	[Token(Token = "0x6000613")]
	private int MapCapnum(int capnum) { }

	[Address(RVA = "0x263C460", Offset = "0x263B860", Length = "0x57")]
	[Token(Token = "0x600060E")]
	private void PatchJump(int offset, int jumpDest) { }

	[Address(RVA = "0x263C4C0", Offset = "0x263B8C0", Length = "0x60E")]
	[Token(Token = "0x600060D")]
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	[Address(RVA = "0x263CAD0", Offset = "0x263BED0", Length = "0xE5")]
	[Token(Token = "0x6000612")]
	private int StringCode(string str) { }

	[Address(RVA = "0x263CBC0", Offset = "0x263BFC0", Length = "0x27A")]
	[Token(Token = "0x600060B")]
	public static RegexCode Write(RegexTree tree) { }

}


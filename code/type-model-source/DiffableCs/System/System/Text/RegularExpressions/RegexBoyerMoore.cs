namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E4")]
internal sealed class RegexBoyerMoore
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000394")]
	public readonly Int32[] Positive; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000395")]
	public readonly Int32[] NegativeASCII; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000396")]
	public readonly Int32[][] NegativeUnicode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000397")]
	public readonly string Pattern; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000398")]
	public readonly int LowASCII; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000399")]
	public readonly int HighASCII; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400039A")]
	public readonly bool RightToLeft; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400039B")]
	public readonly bool CaseInsensitive; //Field offset: 0x39
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400039C")]
	private readonly CultureInfo _culture; //Field offset: 0x40

	[Address(RVA = "0x261A130", Offset = "0x2619530", Length = "0x562")]
	[Token(Token = "0x600050C")]
	public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	[Address(RVA = "0x2619C50", Offset = "0x2619050", Length = "0x6E")]
	[Token(Token = "0x600050E")]
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	[Address(RVA = "0x2619CC0", Offset = "0x26190C0", Length = "0x136")]
	[Token(Token = "0x600050D")]
	private bool MatchPattern(string text, int index) { }

	[Address(RVA = "0x2619E00", Offset = "0x2619200", Length = "0x328")]
	[Token(Token = "0x600050F")]
	public int Scan(string text, int index, int beglimit, int endlimit) { }

}


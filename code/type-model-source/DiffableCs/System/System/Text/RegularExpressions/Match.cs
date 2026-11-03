namespace System.Text.RegularExpressions;

[Token(Token = "0x20000DC")]
public class Match : Group
{
	[CompilerGenerated]
	[Token(Token = "0x4000361")]
	private static readonly Match <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000358")]
	internal GroupCollection _groupcoll; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000359")]
	internal Regex _regex; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400035A")]
	internal int _textbeg; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400035B")]
	internal int _textpos; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400035C")]
	internal int _textend; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400035D")]
	internal int _textstart; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400035E")]
	internal Int32[][] _matches; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400035F")]
	internal Int32[] _matchcount; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000360")]
	internal bool _balancing; //Field offset: 0x70

	[Token(Token = "0x170000CD")]
	public static Match Empty
	{
		[Address(RVA = "0x2619B70", Offset = "0x2618F70", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x60004A7")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000CE")]
	public override GroupCollection Groups
	{
		[Address(RVA = "0x2619BC0", Offset = "0x2618FC0", Length = "0x8C")]
		[Token(Token = "0x60004A9")]
		 get { } //Length: 140
	}

	[Address(RVA = "0x2619910", Offset = "0x2618D10", Length = "0x9D")]
	[Token(Token = "0x60004B4")]
	private static Match() { }

	[Address(RVA = "0x26199B0", Offset = "0x2618DB0", Length = "0x181")]
	[Token(Token = "0x60004A6")]
	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	[Address(RVA = "0x2619B40", Offset = "0x2618F40", Length = "0x2C")]
	[Token(Token = "0x60004B5")]
	internal Match() { }

	[Address(RVA = "0x2618F10", Offset = "0x2618310", Length = "0x1F6")]
	[Token(Token = "0x60004AD")]
	internal override void AddMatch(int cap, int start, int len) { }

	[Address(RVA = "0x2619110", Offset = "0x2618510", Length = "0x141")]
	[Token(Token = "0x60004AE")]
	internal override void BalanceMatch(int cap) { }

	[Address(RVA = "0x2619B70", Offset = "0x2618F70", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x60004A7")]
	public static Match get_Empty() { }

	[Address(RVA = "0x2619BC0", Offset = "0x2618FC0", Length = "0x8C")]
	[Token(Token = "0x60004A9")]
	public override GroupCollection get_Groups() { }

	[Address(RVA = "0x2619260", Offset = "0x2618660", Length = "0x193")]
	[Token(Token = "0x60004AB")]
	internal override ReadOnlySpan<Char> GroupToStringImpl(int groupnum) { }

	[Address(RVA = "0x2619400", Offset = "0x2618800", Length = "0x78")]
	[Token(Token = "0x60004B0")]
	internal override bool IsMatched(int cap) { }

	[Address(RVA = "0x2619480", Offset = "0x2618880", Length = "0x45")]
	[Token(Token = "0x60004AC")]
	internal ReadOnlySpan<Char> LastGroupToStringImpl() { }

	[Address(RVA = "0x26194D0", Offset = "0x26188D0", Length = "0x88")]
	[Token(Token = "0x60004B1")]
	internal override int MatchIndex(int cap) { }

	[Address(RVA = "0x2619560", Offset = "0x2618960", Length = "0x87")]
	[Token(Token = "0x60004B2")]
	internal override int MatchLength(int cap) { }

	[Address(RVA = "0x26195F0", Offset = "0x26189F0", Length = "0x4E")]
	[Token(Token = "0x60004AA")]
	public Match NextMatch() { }

	[Address(RVA = "0x2619640", Offset = "0x2618A40", Length = "0x2B")]
	[Token(Token = "0x60004AF")]
	internal override void RemoveMatch(int cap) { }

	[Address(RVA = "0x2619670", Offset = "0x2618A70", Length = "0xAB")]
	[Token(Token = "0x60004A8")]
	internal override void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	[Address(RVA = "0x2619720", Offset = "0x2618B20", Length = "0x1EC")]
	[Token(Token = "0x60004B3")]
	internal override void Tidy(int textpos) { }

}


namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E9")]
internal sealed class RegexCode
{
	[Token(Token = "0x40003B7")]
	public const int Onerep = 0; //Field offset: 0x0
	[Token(Token = "0x40003D1")]
	public const int Nullcount = 26; //Field offset: 0x0
	[Token(Token = "0x40003D2")]
	public const int Setcount = 27; //Field offset: 0x0
	[Token(Token = "0x40003D4")]
	public const int Lazybranchcount = 29; //Field offset: 0x0
	[Token(Token = "0x40003D5")]
	public const int Nullmark = 30; //Field offset: 0x0
	[Token(Token = "0x40003D6")]
	public const int Setmark = 31; //Field offset: 0x0
	[Token(Token = "0x40003D7")]
	public const int Capturemark = 32; //Field offset: 0x0
	[Token(Token = "0x40003D8")]
	public const int Getmark = 33; //Field offset: 0x0
	[Token(Token = "0x40003D9")]
	public const int Setjump = 34; //Field offset: 0x0
	[Token(Token = "0x40003DA")]
	public const int Backjump = 35; //Field offset: 0x0
	[Token(Token = "0x40003DB")]
	public const int Forejump = 36; //Field offset: 0x0
	[Token(Token = "0x40003DC")]
	public const int Testref = 37; //Field offset: 0x0
	[Token(Token = "0x40003DD")]
	public const int Goto = 38; //Field offset: 0x0
	[Token(Token = "0x40003DE")]
	public const int Prune = 39; //Field offset: 0x0
	[Token(Token = "0x40003DF")]
	public const int Stop = 40; //Field offset: 0x0
	[Token(Token = "0x40003E0")]
	public const int ECMABoundary = 41; //Field offset: 0x0
	[Token(Token = "0x40003E1")]
	public const int NonECMABoundary = 42; //Field offset: 0x0
	[Token(Token = "0x40003E2")]
	public const int Mask = 63; //Field offset: 0x0
	[Token(Token = "0x40003E3")]
	public const int Rtl = 64; //Field offset: 0x0
	[Token(Token = "0x40003E4")]
	public const int Back = 128; //Field offset: 0x0
	[Token(Token = "0x40003E5")]
	public const int Back2 = 256; //Field offset: 0x0
	[Token(Token = "0x40003E6")]
	public const int Ci = 512; //Field offset: 0x0
	[Token(Token = "0x40003D0")]
	public const int Lazybranchmark = 25; //Field offset: 0x0
	[Token(Token = "0x40003CF")]
	public const int Branchmark = 24; //Field offset: 0x0
	[Token(Token = "0x40003D3")]
	public const int Branchcount = 28; //Field offset: 0x0
	[Token(Token = "0x40003CD")]
	public const int Nothing = 22; //Field offset: 0x0
	[Token(Token = "0x40003B8")]
	public const int Notonerep = 1; //Field offset: 0x0
	[Token(Token = "0x40003B9")]
	public const int Setrep = 2; //Field offset: 0x0
	[Token(Token = "0x40003BA")]
	public const int Oneloop = 3; //Field offset: 0x0
	[Token(Token = "0x40003BB")]
	public const int Notoneloop = 4; //Field offset: 0x0
	[Token(Token = "0x40003BC")]
	public const int Setloop = 5; //Field offset: 0x0
	[Token(Token = "0x40003BD")]
	public const int Onelazy = 6; //Field offset: 0x0
	[Token(Token = "0x40003BE")]
	public const int Notonelazy = 7; //Field offset: 0x0
	[Token(Token = "0x40003CE")]
	public const int Lazybranch = 23; //Field offset: 0x0
	[Token(Token = "0x40003C0")]
	public const int One = 9; //Field offset: 0x0
	[Token(Token = "0x40003C1")]
	public const int Notone = 10; //Field offset: 0x0
	[Token(Token = "0x40003C2")]
	public const int Set = 11; //Field offset: 0x0
	[Token(Token = "0x40003BF")]
	public const int Setlazy = 8; //Field offset: 0x0
	[Token(Token = "0x40003C4")]
	public const int Ref = 13; //Field offset: 0x0
	[Token(Token = "0x40003C3")]
	public const int Multi = 12; //Field offset: 0x0
	[Token(Token = "0x40003CB")]
	public const int EndZ = 20; //Field offset: 0x0
	[Token(Token = "0x40003CA")]
	public const int Start = 19; //Field offset: 0x0
	[Token(Token = "0x40003C9")]
	public const int Beginning = 18; //Field offset: 0x0
	[Token(Token = "0x40003CC")]
	public const int End = 21; //Field offset: 0x0
	[Token(Token = "0x40003C7")]
	public const int Boundary = 16; //Field offset: 0x0
	[Token(Token = "0x40003C6")]
	public const int Eol = 15; //Field offset: 0x0
	[Token(Token = "0x40003C5")]
	public const int Bol = 14; //Field offset: 0x0
	[Token(Token = "0x40003C8")]
	public const int Nonboundary = 17; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E7")]
	public readonly Int32[] Codes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003E8")]
	public readonly String[] Strings; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003E9")]
	public readonly int TrackCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003EA")]
	public readonly Hashtable Caps; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003EB")]
	public readonly int CapSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003EC")]
	public readonly Nullable<RegexPrefix> FCPrefix; //Field offset: 0x38
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003ED")]
	public readonly RegexBoyerMoore BMPrefix; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003EE")]
	public readonly int Anchors; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40003EF")]
	public readonly bool RightToLeft; //Field offset: 0x5C

	[Address(RVA = "0x2622830", Offset = "0x2621C30", Length = "0xF6")]
	[Token(Token = "0x600053C")]
	public RegexCode(Int32[] codes, List<String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, Nullable<RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	[Address(RVA = "0x26227D0", Offset = "0x2621BD0", Length = "0x20")]
	[Token(Token = "0x600053D")]
	public static bool OpcodeBacktracks(int Op) { }

}


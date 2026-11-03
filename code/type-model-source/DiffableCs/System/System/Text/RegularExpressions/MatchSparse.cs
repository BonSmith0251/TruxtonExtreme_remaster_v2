namespace System.Text.RegularExpressions;

[Token(Token = "0x20000DD")]
internal class MatchSparse : Match
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000362")]
	internal readonly Hashtable _caps; //Field offset: 0x78

	[Token(Token = "0x170000CF")]
	public virtual GroupCollection Groups
	{
		[Address(RVA = "0x2618E70", Offset = "0x2618270", Length = "0x97")]
		[Token(Token = "0x60004B7")]
		 get { } //Length: 151
	}

	[Address(RVA = "0x2618DC0", Offset = "0x26181C0", Length = "0xAF")]
	[Token(Token = "0x60004B6")]
	internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	[Address(RVA = "0x2618E70", Offset = "0x2618270", Length = "0x97")]
	[Token(Token = "0x60004B7")]
	public virtual GroupCollection get_Groups() { }

}


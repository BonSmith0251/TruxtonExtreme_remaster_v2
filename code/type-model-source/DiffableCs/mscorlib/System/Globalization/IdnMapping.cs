namespace System.Globalization;

[Token(Token = "0x200057D")]
public sealed class IdnMapping
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400173C")]
	private bool allow_unassigned; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400173D")]
	private bool use_std3; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400173E")]
	private Punycode puny; //Field offset: 0x18

	[Address(RVA = "0x1FC8510", Offset = "0x1FC7910", Length = "0x9D")]
	[Token(Token = "0x60028B6")]
	public IdnMapping() { }

	[Address(RVA = "0x1FC72C0", Offset = "0x1FC66C0", Length = "0x1F9")]
	[Token(Token = "0x60028BB")]
	private string Convert(string input, int index, int count, bool toAscii) { }

	[Address(RVA = "0x1FC74C0", Offset = "0x1FC68C0", Length = "0x74")]
	[Token(Token = "0x60028B7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1FC7540", Offset = "0x1FC6940", Length = "0xC1")]
	[Token(Token = "0x60028B9")]
	public string GetAscii(string unicode) { }

	[Address(RVA = "0x1FC7610", Offset = "0x1FC6A10", Length = "0x115")]
	[Token(Token = "0x60028BA")]
	public string GetAscii(string unicode, int index, int count) { }

	[Address(RVA = "0x1FC7730", Offset = "0x1FC6B30", Length = "0x18")]
	[Token(Token = "0x60028B8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1FC7870", Offset = "0x1FC6C70", Length = "0xC1")]
	[Token(Token = "0x60028C1")]
	public string GetUnicode(string ascii) { }

	[Address(RVA = "0x1FC7750", Offset = "0x1FC6B50", Length = "0x115")]
	[Token(Token = "0x60028C2")]
	public string GetUnicode(string ascii, int index, int count) { }

	[Address(RVA = "0x1FC7940", Offset = "0x1FC6D40", Length = "0x115")]
	[Token(Token = "0x60028BE")]
	private string NamePrep(string s, int offset) { }

	[Address(RVA = "0x1FC7A60", Offset = "0x1FC6E60", Length = "0x354")]
	[Token(Token = "0x60028BC")]
	private string ToAscii(string s, int offset) { }

	[Address(RVA = "0x1FC7DC0", Offset = "0x1FC71C0", Length = "0x1C1")]
	[Token(Token = "0x60028C3")]
	private string ToUnicode(string s, int offset) { }

	[Address(RVA = "0x1FC7F90", Offset = "0x1FC7390", Length = "0x121")]
	[Token(Token = "0x60028BD")]
	private void VerifyLength(string s, int offset) { }

	[Address(RVA = "0x1FC80C0", Offset = "0x1FC74C0", Length = "0x1D8")]
	[Token(Token = "0x60028BF")]
	private void VerifyProhibitedCharacters(string s, int offset) { }

	[Address(RVA = "0x1FC82C0", Offset = "0x1FC76C0", Length = "0x24D")]
	[Token(Token = "0x60028C0")]
	private void VerifyStd3AsciiRules(string s, int offset) { }

}


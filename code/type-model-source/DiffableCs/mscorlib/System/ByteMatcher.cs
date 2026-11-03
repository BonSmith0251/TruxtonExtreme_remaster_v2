namespace System;

[Token(Token = "0x20001CC")]
internal class ByteMatcher
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000755")]
	private Hashtable map; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000756")]
	private Hashtable starts; //Field offset: 0x18

	[Address(RVA = "0x207B120", Offset = "0x207A520", Length = "0x85")]
	[Token(Token = "0x600107A")]
	public ByteMatcher() { }

	[Address(RVA = "0x207ACE0", Offset = "0x207A0E0", Length = "0x10F")]
	[Token(Token = "0x6001076")]
	public void AddMapping(TermInfoStrings key, Byte[] val) { }

	[Address(RVA = "0x207ADF0", Offset = "0x207A1F0", Length = "0x2D5")]
	[Token(Token = "0x6001079")]
	public TermInfoStrings Match(Char[] buffer, int offset, int length, out int used) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001077")]
	public void Sort() { }

	[Address(RVA = "0x207B0D0", Offset = "0x207A4D0", Length = "0x4F")]
	[Token(Token = "0x6001078")]
	public bool StartsWith(int c) { }

}


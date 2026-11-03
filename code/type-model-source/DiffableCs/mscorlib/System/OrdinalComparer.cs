namespace System;

[Token(Token = "0x2000136")]
public class OrdinalComparer : StringComparer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000444")]
	private readonly bool _ignoreCase; //Field offset: 0x10

	[Address(RVA = "0x2044590", Offset = "0x2043990", Length = "0x5A")]
	[Token(Token = "0x6000A30")]
	internal OrdinalComparer(bool ignoreCase) { }

	[Address(RVA = "0x2044360", Offset = "0x2043760", Length = "0x46")]
	[Token(Token = "0x6000A31")]
	public virtual int Compare(string x, string y) { }

	[Address(RVA = "0x20443B0", Offset = "0x20437B0", Length = "0x66")]
	[Token(Token = "0x6000A32")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0x2044420", Offset = "0x2043820", Length = "0x7E")]
	[Token(Token = "0x6000A34")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x20444A0", Offset = "0x20438A0", Length = "0x8A")]
	[Token(Token = "0x6000A33")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x2044530", Offset = "0x2043930", Length = "0x5A")]
	[Token(Token = "0x6000A35")]
	public virtual int GetHashCode() { }

}


namespace System.Xml;

[Token(Token = "0x20000B8")]
public class NameTable : XmlNameTable
{
	[Token(Token = "0x20000B9")]
	private class Entry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BC")]
		internal string str; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004BD")]
		internal int hashCode; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004BE")]
		internal Entry next; //Field offset: 0x20

		[Address(RVA = "0x20C7F80", Offset = "0x20C7380", Length = "0x5E")]
		[Token(Token = "0x60009FA")]
		internal Entry(string str, int hashCode, Entry next) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B8")]
	private Entry[] entries; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B9")]
	private int count; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004BA")]
	private int mask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004BB")]
	private int hashCodeRandomizer; //Field offset: 0x20

	[Address(RVA = "0x2536A70", Offset = "0x2535E70", Length = "0x67")]
	[Token(Token = "0x60009F3")]
	public NameTable() { }

	[Address(RVA = "0x2536440", Offset = "0x2535840", Length = "0x163")]
	[Token(Token = "0x60009F4")]
	public virtual string Add(string key) { }

	[Address(RVA = "0x25365B0", Offset = "0x25359B0", Length = "0x1E5")]
	[Token(Token = "0x60009F5")]
	public virtual string Add(Char[] key, int start, int len) { }

	[Address(RVA = "0x25361D0", Offset = "0x25355D0", Length = "0x26B")]
	[Token(Token = "0x60009F7")]
	private string AddEntry(string str, int hashCode) { }

	[Address(RVA = "0x25367A0", Offset = "0x2535BA0", Length = "0x154")]
	[Token(Token = "0x60009F6")]
	public virtual string Get(string value) { }

	[Address(RVA = "0x2536900", Offset = "0x2535D00", Length = "0x161")]
	[Token(Token = "0x60009F8")]
	private void Grow() { }

	[Address(RVA = "0x20C7E40", Offset = "0x20C7240", Length = "0x99")]
	[Token(Token = "0x60009F9")]
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}


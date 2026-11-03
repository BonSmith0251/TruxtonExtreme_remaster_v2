namespace System.Xml;

[Token(Token = "0x20000DB")]
public abstract class XmlNameTable
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B68")]
	protected XmlNameTable() { }

	[Token(Token = "0x6000B66")]
	public abstract string Add(Char[] array, int offset, int length) { }

	[Token(Token = "0x6000B67")]
	public abstract string Add(string array) { }

	[Token(Token = "0x6000B65")]
	public abstract string Get(string array) { }

}


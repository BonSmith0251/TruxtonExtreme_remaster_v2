namespace System.IO;

[Token(Token = "0x2000682")]
internal class UnexceptionalStreamWriter : StreamWriter
{

	[Address(RVA = "0x20051D0", Offset = "0x20045D0", Length = "0x7B")]
	[Token(Token = "0x60030FD")]
	public UnexceptionalStreamWriter(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x2005130", Offset = "0x2004530", Length = "0x13")]
	[Token(Token = "0x60030FE")]
	public virtual void Flush() { }

	[Address(RVA = "0x2005190", Offset = "0x2004590", Length = "0x1A")]
	[Token(Token = "0x60030FF")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2005150", Offset = "0x2004550", Length = "0x14")]
	[Token(Token = "0x6003100")]
	public virtual void Write(char value) { }

	[Address(RVA = "0x20051B0", Offset = "0x20045B0", Length = "0x14")]
	[Token(Token = "0x6003101")]
	public virtual void Write(Char[] value) { }

	[Address(RVA = "0x2005170", Offset = "0x2004570", Length = "0x14")]
	[Token(Token = "0x6003102")]
	public virtual void Write(string value) { }

}


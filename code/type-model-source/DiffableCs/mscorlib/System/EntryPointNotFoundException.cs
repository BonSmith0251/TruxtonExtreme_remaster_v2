namespace System;

[Token(Token = "0x20000CF")]
public class EntryPointNotFoundException : TypeLoadException
{

	[Address(RVA = "0x2020FC0", Offset = "0x20203C0", Length = "0x44")]
	[Token(Token = "0x6000698")]
	public EntryPointNotFoundException() { }

	[Address(RVA = "0x2021010", Offset = "0x2020410", Length = "0x1E")]
	[Token(Token = "0x6000699")]
	public EntryPointNotFoundException(string message) { }

	[Address(RVA = "0x201FCF0", Offset = "0x201F0F0", Length = "0x1F")]
	[Token(Token = "0x600069A")]
	protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) { }

}


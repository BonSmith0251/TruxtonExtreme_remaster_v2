namespace System;

[Token(Token = "0x20000CD")]
public class DllNotFoundException : TypeLoadException
{

	[Address(RVA = "0x201FD30", Offset = "0x201F130", Length = "0x44")]
	[Token(Token = "0x600066F")]
	public DllNotFoundException() { }

	[Address(RVA = "0x201FD10", Offset = "0x201F110", Length = "0x1E")]
	[Token(Token = "0x6000670")]
	public DllNotFoundException(string message) { }

	[Address(RVA = "0x201FCF0", Offset = "0x201F0F0", Length = "0x1F")]
	[Token(Token = "0x6000671")]
	protected DllNotFoundException(SerializationInfo info, StreamingContext context) { }

}


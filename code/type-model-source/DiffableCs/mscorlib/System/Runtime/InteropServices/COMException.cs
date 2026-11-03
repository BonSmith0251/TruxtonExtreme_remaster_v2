namespace System.Runtime.InteropServices;

[Token(Token = "0x2000441")]
public class COMException : ExternalException
{

	[Address(RVA = "0x1F33020", Offset = "0x1F32420", Length = "0x44")]
	[Token(Token = "0x600201D")]
	public COMException() { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600201E")]
	protected COMException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F32E40", Offset = "0x1F32240", Length = "0x1D6")]
	[Token(Token = "0x600201F")]
	public virtual string ToString() { }

}


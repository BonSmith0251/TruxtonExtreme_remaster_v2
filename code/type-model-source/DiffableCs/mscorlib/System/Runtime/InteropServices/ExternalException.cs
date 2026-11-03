namespace System.Runtime.InteropServices;

[Token(Token = "0x200043B")]
public class ExternalException : SystemException
{

	[Address(RVA = "0x1F33020", Offset = "0x1F32420", Length = "0x44")]
	[Token(Token = "0x6002005")]
	public ExternalException() { }

	[Address(RVA = "0x1F348E0", Offset = "0x1F33CE0", Length = "0x1E")]
	[Token(Token = "0x6002006")]
	public ExternalException(string message) { }

	[Address(RVA = "0x1F34900", Offset = "0x1F33D00", Length = "0x26")]
	[Token(Token = "0x6002007")]
	public ExternalException(string message, int errorCode) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002008")]
	protected ExternalException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F34700", Offset = "0x1F33B00", Length = "0x1D9")]
	[Token(Token = "0x6002009")]
	public virtual string ToString() { }

}


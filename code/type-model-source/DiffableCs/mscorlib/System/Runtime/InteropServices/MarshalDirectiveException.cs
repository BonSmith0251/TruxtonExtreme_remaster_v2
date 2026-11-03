namespace System.Runtime.InteropServices;

[Token(Token = "0x200043D")]
public class MarshalDirectiveException : SystemException
{

	[Address(RVA = "0x1F36BD0", Offset = "0x1F35FD0", Length = "0x44")]
	[Token(Token = "0x600200C")]
	public MarshalDirectiveException() { }

	[Address(RVA = "0x1F36C20", Offset = "0x1F36020", Length = "0x1E")]
	[Token(Token = "0x600200D")]
	public MarshalDirectiveException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600200E")]
	protected MarshalDirectiveException(SerializationInfo info, StreamingContext context) { }

}


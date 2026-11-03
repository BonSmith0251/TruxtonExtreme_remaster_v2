namespace System.Data;

[Token(Token = "0x2000010")]
public class DuplicateNameException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000AC")]
	protected DuplicateNameException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x23000C0", Offset = "0x22FF4C0", Length = "0x44")]
	[Token(Token = "0x60000AD")]
	public DuplicateNameException() { }

	[Address(RVA = "0x23000A0", Offset = "0x22FF4A0", Length = "0x1E")]
	[Token(Token = "0x60000AE")]
	public DuplicateNameException(string s) { }

}


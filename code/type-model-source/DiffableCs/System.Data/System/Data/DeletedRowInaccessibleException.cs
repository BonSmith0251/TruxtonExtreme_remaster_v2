namespace System.Data;

[Token(Token = "0x200000F")]
public class DeletedRowInaccessibleException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000A9")]
	protected DeletedRowInaccessibleException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2300030", Offset = "0x22FF430", Length = "0x44")]
	[Token(Token = "0x60000AA")]
	public DeletedRowInaccessibleException() { }

	[Address(RVA = "0x2300080", Offset = "0x22FF480", Length = "0x1E")]
	[Token(Token = "0x60000AB")]
	public DeletedRowInaccessibleException(string s) { }

}


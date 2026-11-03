namespace System.Data;

[Token(Token = "0x2000015")]
public class RowNotInTableException : DataException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000BB")]
	protected RowNotInTableException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x230F6D0", Offset = "0x230EAD0", Length = "0x44")]
	[Token(Token = "0x60000BC")]
	public RowNotInTableException() { }

	[Address(RVA = "0x230F720", Offset = "0x230EB20", Length = "0x1E")]
	[Token(Token = "0x60000BD")]
	public RowNotInTableException(string s) { }

}


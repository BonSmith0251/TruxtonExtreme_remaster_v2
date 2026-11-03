namespace System.Data;

[Token(Token = "0x200000D")]
public class DataException : SystemException
{

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60000A2")]
	protected DataException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22F4460", Offset = "0x22F3860", Length = "0x44")]
	[Token(Token = "0x60000A3")]
	public DataException() { }

	[Address(RVA = "0x22F4440", Offset = "0x22F3840", Length = "0x1E")]
	[Token(Token = "0x60000A4")]
	public DataException(string s) { }

	[Address(RVA = "0x1EE9350", Offset = "0x1EE8750", Length = "0x8")]
	[Token(Token = "0x60000A5")]
	public DataException(string s, Exception innerException) { }

}


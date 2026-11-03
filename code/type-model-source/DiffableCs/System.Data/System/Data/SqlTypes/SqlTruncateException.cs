namespace System.Data.SqlTypes;

[Token(Token = "0x20000BC")]
public sealed class SqlTruncateException : SqlTypeException
{

	[Address(RVA = "0x23A57B0", Offset = "0x23A4BB0", Length = "0x2E")]
	[Token(Token = "0x6000A6D")]
	public SqlTruncateException() { }

	[Address(RVA = "0x23A58E0", Offset = "0x23A4CE0", Length = "0x21")]
	[Token(Token = "0x6000A6E")]
	public SqlTruncateException(string message) { }

	[Address(RVA = "0x23A5790", Offset = "0x23A4B90", Length = "0x1E")]
	[Token(Token = "0x6000A6F")]
	public SqlTruncateException(string message, Exception e) { }

	[Address(RVA = "0x23A57E0", Offset = "0x23A4BE0", Length = "0xFA")]
	[Token(Token = "0x6000A70")]
	private SqlTruncateException(SerializationInfo si, StreamingContext sc) { }

	[Address(RVA = "0x23A56B0", Offset = "0x23A4AB0", Length = "0xD2")]
	[Token(Token = "0x6000A71")]
	private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}


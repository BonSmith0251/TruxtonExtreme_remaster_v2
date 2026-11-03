namespace System.Data.SqlTypes;

[Token(Token = "0x20000BA")]
public class SqlTypeException : SystemException
{

	[Address(RVA = "0x23A5A40", Offset = "0x23A4E40", Length = "0x47")]
	[Token(Token = "0x6000A63")]
	public SqlTypeException() { }

	[Address(RVA = "0x23A5A10", Offset = "0x23A4E10", Length = "0x21")]
	[Token(Token = "0x6000A64")]
	public SqlTypeException(string message) { }

	[Address(RVA = "0x23A59F0", Offset = "0x23A4DF0", Length = "0x1E")]
	[Token(Token = "0x6000A65")]
	public SqlTypeException(string message, Exception e) { }

	[Address(RVA = "0x23A5A90", Offset = "0x23A4E90", Length = "0xFA")]
	[Token(Token = "0x6000A66")]
	protected SqlTypeException(SerializationInfo si, StreamingContext sc) { }

	[Address(RVA = "0x23A5910", Offset = "0x23A4D10", Length = "0xD2")]
	[Token(Token = "0x6000A67")]
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}


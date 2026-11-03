namespace System.Data.SqlTypes;

[Token(Token = "0x20000BB")]
public sealed class SqlNullValueException : SqlTypeException
{

	[Address(RVA = "0x23A1410", Offset = "0x23A0810", Length = "0x2E")]
	[Token(Token = "0x6000A68")]
	public SqlNullValueException() { }

	[Address(RVA = "0x23A1560", Offset = "0x23A0960", Length = "0x21")]
	[Token(Token = "0x6000A69")]
	public SqlNullValueException(string message) { }

	[Address(RVA = "0x23A1440", Offset = "0x23A0840", Length = "0x1E")]
	[Token(Token = "0x6000A6A")]
	public SqlNullValueException(string message, Exception e) { }

	[Address(RVA = "0x23A1460", Offset = "0x23A0860", Length = "0xFA")]
	[Token(Token = "0x6000A6B")]
	private SqlNullValueException(SerializationInfo si, StreamingContext sc) { }

	[Address(RVA = "0x23A1330", Offset = "0x23A0730", Length = "0xD2")]
	[Token(Token = "0x6000A6C")]
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}


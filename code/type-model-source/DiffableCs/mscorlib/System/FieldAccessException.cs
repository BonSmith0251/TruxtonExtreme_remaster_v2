namespace System;

[Token(Token = "0x20000D4")]
public class FieldAccessException : MemberAccessException
{

	[Address(RVA = "0x2021130", Offset = "0x2020530", Length = "0x44")]
	[Token(Token = "0x60006A4")]
	public FieldAccessException() { }

	[Address(RVA = "0x2021110", Offset = "0x2020510", Length = "0x1E")]
	[Token(Token = "0x60006A5")]
	public FieldAccessException(string message) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x60006A6")]
	protected FieldAccessException(SerializationInfo info, StreamingContext context) { }

}


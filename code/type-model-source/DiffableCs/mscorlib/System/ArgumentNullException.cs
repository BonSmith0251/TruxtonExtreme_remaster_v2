namespace System;

[Token(Token = "0x20000B2")]
public class ArgumentNullException : ArgumentException
{

	[Address(RVA = "0x1F8C260", Offset = "0x1F8B660", Length = "0x44")]
	[Token(Token = "0x60003E5")]
	public ArgumentNullException() { }

	[Address(RVA = "0x1F8C1F0", Offset = "0x1F8B5F0", Length = "0x66")]
	[Token(Token = "0x60003E6")]
	public ArgumentNullException(string paramName) { }

	[Address(RVA = "0x1F8C2B0", Offset = "0x1F8B6B0", Length = "0x46")]
	[Token(Token = "0x60003E7")]
	public ArgumentNullException(string paramName, string message) { }

	[Address(RVA = "0x1F8C090", Offset = "0x1F8B490", Length = "0x90")]
	[Token(Token = "0x60003E8")]
	protected ArgumentNullException(SerializationInfo info, StreamingContext context) { }

}


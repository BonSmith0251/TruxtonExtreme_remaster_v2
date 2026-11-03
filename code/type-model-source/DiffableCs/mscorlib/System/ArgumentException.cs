namespace System;

[Token(Token = "0x20000B1")]
public class ArgumentException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400027E")]
	private string _paramName; //Field offset: 0x90

	[Token(Token = "0x1700004F")]
	public virtual string Message
	{
		[Address(RVA = "0x1F8C150", Offset = "0x1F8B550", Length = "0x91")]
		[Token(Token = "0x60003E4")]
		 get { } //Length: 145
	}

	[Address(RVA = "0x1F8BFB0", Offset = "0x1F8B3B0", Length = "0x44")]
	[Token(Token = "0x60003DD")]
	public ArgumentException() { }

	[Address(RVA = "0x1F8BF90", Offset = "0x1F8B390", Length = "0x1E")]
	[Token(Token = "0x60003DE")]
	public ArgumentException(string message) { }

	[Address(RVA = "0x1F8C130", Offset = "0x1F8B530", Length = "0x1E")]
	[Token(Token = "0x60003DF")]
	public ArgumentException(string message, Exception innerException) { }

	[Address(RVA = "0x1F8C000", Offset = "0x1F8B400", Length = "0x46")]
	[Token(Token = "0x60003E0")]
	public ArgumentException(string message, string paramName, Exception innerException) { }

	[Address(RVA = "0x1F8C050", Offset = "0x1F8B450", Length = "0x40")]
	[Token(Token = "0x60003E1")]
	public ArgumentException(string message, string paramName) { }

	[Address(RVA = "0x1F8C090", Offset = "0x1F8B490", Length = "0x90")]
	[Token(Token = "0x60003E2")]
	protected ArgumentException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F8C150", Offset = "0x1F8B550", Length = "0x91")]
	[Token(Token = "0x60003E4")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1F8BED0", Offset = "0x1F8B2D0", Length = "0xB5")]
	[Token(Token = "0x60003E3")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


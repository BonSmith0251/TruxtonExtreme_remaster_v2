namespace System;

[Token(Token = "0x20000B3")]
public class ArgumentOutOfRangeException : ArgumentException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400027F")]
	private object _actualValue; //Field offset: 0x98

	[Token(Token = "0x17000050")]
	public virtual string Message
	{
		[Address(RVA = "0x1F8C6C0", Offset = "0x1F8BAC0", Length = "0x116")]
		[Token(Token = "0x60003EF")]
		 get { } //Length: 278
	}

	[Address(RVA = "0x1F8C5B0", Offset = "0x1F8B9B0", Length = "0x44")]
	[Token(Token = "0x60003E9")]
	public ArgumentOutOfRangeException() { }

	[Address(RVA = "0x1F8C600", Offset = "0x1F8BA00", Length = "0x66")]
	[Token(Token = "0x60003EA")]
	public ArgumentOutOfRangeException(string paramName) { }

	[Address(RVA = "0x1F8C670", Offset = "0x1F8BA70", Length = "0x46")]
	[Token(Token = "0x60003EB")]
	public ArgumentOutOfRangeException(string paramName, string message) { }

	[Address(RVA = "0x1F8C430", Offset = "0x1F8B830", Length = "0x6D")]
	[Token(Token = "0x60003EC")]
	public ArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	[Address(RVA = "0x1F8C4A0", Offset = "0x1F8B8A0", Length = "0x102")]
	[Token(Token = "0x60003ED")]
	protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F8C6C0", Offset = "0x1F8BAC0", Length = "0x116")]
	[Token(Token = "0x60003EF")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1F8C300", Offset = "0x1F8B700", Length = "0x127")]
	[Token(Token = "0x60003EE")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


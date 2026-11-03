namespace System;

[Token(Token = "0x2000149")]
public sealed class TypeInitializationException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000477")]
	private string _typeName; //Field offset: 0x90

	[Token(Token = "0x170000F0")]
	public string TypeName
	{
		[Address(RVA = "0x2043AA0", Offset = "0x2042EA0", Length = "0x24")]
		[Token(Token = "0x6000B47")]
		 get { } //Length: 36
	}

	[Address(RVA = "0x204ED30", Offset = "0x204E130", Length = "0x81")]
	[Token(Token = "0x6000B42")]
	private TypeInitializationException() { }

	[Address(RVA = "0x204EDC0", Offset = "0x204E1C0", Length = "0xC9")]
	[Token(Token = "0x6000B43")]
	public TypeInitializationException(string fullTypeName, Exception innerException) { }

	[Address(RVA = "0x204EF60", Offset = "0x204E360", Length = "0x9B")]
	[Token(Token = "0x6000B44")]
	internal TypeInitializationException(string fullTypeName, string message, Exception innerException) { }

	[Address(RVA = "0x204EE90", Offset = "0x204E290", Length = "0xC1")]
	[Token(Token = "0x6000B45")]
	internal TypeInitializationException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2043AA0", Offset = "0x2042EA0", Length = "0x24")]
	[Token(Token = "0x6000B47")]
	public string get_TypeName() { }

	[Address(RVA = "0x204EC40", Offset = "0x204E040", Length = "0xE8")]
	[Token(Token = "0x6000B46")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


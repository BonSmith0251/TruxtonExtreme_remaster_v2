namespace System;

[Token(Token = "0x20000BF")]
public class UriFormatException : FormatException, ISerializable
{

	[Address(RVA = "0x260E440", Offset = "0x260D840", Length = "0x7")]
	[Token(Token = "0x60003F8")]
	public UriFormatException() { }

	[Address(RVA = "0x260E460", Offset = "0x260D860", Length = "0x8")]
	[Token(Token = "0x60003F9")]
	public UriFormatException(string textString) { }

	[Address(RVA = "0x260E450", Offset = "0x260D850", Length = "0x8")]
	[Token(Token = "0x60003FA")]
	public UriFormatException(string textString, Exception e) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x60003FB")]
	protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x260E420", Offset = "0x260D820", Length = "0x1F")]
	[Token(Token = "0x60003FC")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}


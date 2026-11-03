namespace System;

[Token(Token = "0x200016B")]
public class MissingMemberException : MemberAccessException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000557")]
	protected string ClassName; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000558")]
	protected string MemberName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000559")]
	protected Byte[] Signature; //Field offset: 0xA0

	[Token(Token = "0x17000108")]
	public virtual string Message
	{
		[Address(RVA = "0x20435D0", Offset = "0x20429D0", Length = "0xF0")]
		[Token(Token = "0x6000CA4")]
		 get { } //Length: 240
	}

	[Address(RVA = "0x20433A0", Offset = "0x20427A0", Length = "0x44")]
	[Token(Token = "0x6000CA0")]
	public MissingMemberException() { }

	[Address(RVA = "0x20433F0", Offset = "0x20427F0", Length = "0x1E")]
	[Token(Token = "0x6000CA1")]
	public MissingMemberException(string message) { }

	[Address(RVA = "0x2043410", Offset = "0x2042810", Length = "0x1BC")]
	[Token(Token = "0x6000CA2")]
	protected MissingMemberException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000CA5")]
	internal static string FormatSignature(Byte[] signature) { }

	[Address(RVA = "0x20435D0", Offset = "0x20429D0", Length = "0xF0")]
	[Token(Token = "0x6000CA4")]
	public virtual string get_Message() { }

	[Address(RVA = "0x20431F0", Offset = "0x20425F0", Length = "0x1AB")]
	[Token(Token = "0x6000CA3")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

